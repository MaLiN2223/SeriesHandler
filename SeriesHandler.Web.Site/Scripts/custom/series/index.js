import ReactDOM from "react-dom";
import SeriesForm from "./seriesInput";

console.log("Executing index.js");
console.log(SeriesForm);
console.log(document.getElementById("root"));
ReactDOM.render(React.createElement(SeriesForm,
    {
        value: {},
        onChange: function (contact) { console.log(contact) }

    }),
    document.getElementById("root"));