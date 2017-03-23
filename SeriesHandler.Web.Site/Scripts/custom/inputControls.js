"use strict";

var InputRow = React.createClass({
    displayName: "InputRow",
    onChange: function (text) {
        text = text.target.value;
        if (this.props.onChange !== undefined) {
            text = this.props.onChange(text);
        }
        this.setState({ value: text });
    },
    getInitialState: function () {
        return {
            value: ""
        }
    },

    propTypes: {
        id: React.PropTypes.string.isRequired,
        type: React.PropTypes.string.isRequired,
        labelText: React.PropTypes.string.isRequired,
    },
    render: function () {
        return React.createElement("div",
            { className: "form-group" },
            React.createElement("label",
                { className: "control-label col-sm-2", htmlFor: this.props.id },
                this.props.labelText),
            React.createElement("input",
                {
                    type: this.props.type,
                    className: "form-control",
                    id: this.props.id,
                    placeholder: this.props.placeholder,
                    value: this.state.value,
                    onChange: this.onChange,
                })
        );
    }
});

var DatePickerRow = React.createClass({
    displayName: "DatePickerRow",
    getInitialState: function () {
        return {
            value: ""
        }
    },
    render: function () {
        return React.createElement("div",
            { className: "form-group" },
            React.createElement("label",
                { className: "control-label col-sm-2", htmlFor: this.props.id },
                this.props.labelText),
            React.createElement(DatePicker,
                {
                    
                })
        );
    }
});
var TextAreaRow = React.createClass({
    displayName: "TextAreaRow",
    onChange: function (text) {
        text = text.target.value;
        if (this.props.onChange !== undefined) {
            text = this.props.onChange(text);
        }
        this.setState({ value: text });
    },
    getInitialState: function () {
        return {
            value: ""
        }
    },

    propTypes: {
        id: React.PropTypes.string.isRequired,
        type: React.PropTypes.string.isRequired,
        labelText: React.PropTypes.string.isRequired,
    },
    render: function () {
        return React.createElement("div",
            { className: "form-group" },
            React.createElement("label",
                { className: "control-label col-sm-2", htmlFor: this.props.id },
                this.props.labelText),
            React.createElement("textarea",
                {
                    type: this.props.type,
                    className: "form-control",
                    id: this.props.id,
                    placeholder: this.props.placeholder,
                    value: this.state.value,
                    onChange: this.onChange,
                })
        );
    }
});