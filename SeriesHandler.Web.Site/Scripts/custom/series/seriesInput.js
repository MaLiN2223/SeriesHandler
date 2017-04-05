"use strict";
import { InputRow, DatePickerRow, TextAreaRow } from "./inputControls";

const APIURL = "http://localhost:5524/api/Series/";
function seriesData() {
    this.title = "";
    this.year = 0;
    this.description = "";
}
var SeriesForm = React.createClass({
    displayName: "SeriesForm",
    getInitialState: function () {
        return { data: new seriesData() };
    },
    onButtonClick: function (e) {
        console.log(this.state);
        let data = {
            StartDate: "2017-03-22T19:14:42.122Z",
            EndDate: "2017-03-22T19:14:42.122Z",
            Title: this.state.data.title,
            Description: this.state.data.description
        };
        console.log("Title ?: " + this.state.data.title);
        console.log("Description " + this.state.data.description);
        $.ajax({
            contentType: 'application/json',
            data: JSON.stringify(data),
            dataType: 'json',
            success: function (data) {
                alert(data);
                console.log("device control succeeded");
            },
            error: function (ex) {
                console.log(ex);
                alert("asd");
            },
            processData: false,
            type: 'POST',
            url: APIURL

        });
        e.preventDefault();
    },
    defaultFieldChange: function (fieldId) {
        var q = this;
        return function (value) {
            var data = q.state["data"];
            data[fieldId] = value;
            q.setState({ data: data });
            return value;
        };
    },
    handleNumericFieldChange: function (fieldId) {
        var q = this;
        return function (value) {

            var data = q.state["data"];
            data[fieldId] = value;
            q.setState({ data: data });
            return value;
        };
    },
    render: function () {
        return (
            React.createElement('form',
                { className: 'form-horizontal' },
                React.createElement(InputRow,
                    {
                        type: 'text',
                        placeholder: 'Title (required)',
                        labelText: "Title",
                        id: "title",
                        onChange: this.defaultFieldChange("title")
                    }),
                React.createElement(DatePickerRow,
                    {
                        type: 'text',
                        placeholder: 'Year',
                        labelText: "Year",
                        id: "year",
                        onChange: this.defaultFieldChange("year")
                    }),
                React.createElement(TextAreaRow,
                    {
                        type: 'text',
                        placeholder: 'Description',
                        labelText: "Description",
                        id: "description",
                        onChange: this.defaultFieldChange("description")
                    }),
                React.createElement('button',
                    {
                        type: 'submit',
                        onClick: this.onButtonClick
                    },
                    "Add Series")
            )
        );
    }
});
export default SeriesForm;  