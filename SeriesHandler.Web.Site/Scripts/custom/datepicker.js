var DatePicker = React.createClass({
    displayName: 'DatePicker',
    getInitialState: function () {
        return {
            value: undefined
        }
    },
    todayDate: function () {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1;
        var yyyy = today.getFullYear();
        form = "yyyy-mm-dd";
        return form.replace("yyyy", yyyy).replace("mm", mm).replace("dd", dd);
    },
    onBlur: function () {
        console.log("Blurred");
    },
    onChange: function (text) {
        text = text.target.value;
        console.log(text);
    },
    onClick : function (){
        console.log("Clicked");
    },
    render: function () {
        return React.createElement(
            "div", {},
            React.createElement("input",
                {
                    className: "form-control",
                    placeholder: this.todayDate(),
                    value: this.state.value,
                    onBlur: this.onBlur,
                    onChange: this.onChange,
                    onClick : this.onClick
                })
        );
    }
});