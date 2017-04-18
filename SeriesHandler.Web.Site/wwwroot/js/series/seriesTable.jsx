class Series {
    constructor(title, year, id) {
        this.title = title;
        this.year = year;
        this.id = id;
    }
}

class SingleSeries extends React.Component {
    constructor(props) {
        super(props);
    },
    static propTypes = {
        title: React.PropTypes.string.isRequired,
        price: React.PropTypes.number.isRequired,
        initialQty: React.PropTypes.number
    };    
    render() {
        return <tr>
            <td>{this.props.title}</td><td>{this.props.year}</td>
        </tr>;
    }
};
class SeriesTable extends React.Component {
    constructor(props) {
        super(props);
    }
}

var SeriesTable = React.createClass({
    displayName: "SeriesTable",
    getInitialState: function () {
        return {
            titles: [
                new Series("first", 2000, 0),
                new Series("second", 2001, 1)
            ]
        };
    },
    refresh: function () {
        var a = this;
    },
    render: function () {
        var i = 0;
        var rows = this.state.titles.map(function (series) {
            i += 1;
            return React.createElement(SingleSeries, {
                title: series.title,
                year: series.year,
                key: series.id
            });
        });
        return React.createElement(
            "table",
            {
                className: 'table'
            },
            React.createElement(
                'thead',
                null,
                React.createElement(
                    'tr',
                    null,
                    React.createElement(
                        'th',
                        null,
                        'Title'
                    ),
                    React.createElement(
                        'th',
                        null,
                        'Year'
                    )
                )
            ),
            React.createElement(
                "tbody",
                null,
                rows
            )
        );
    }
});

export default SeriesTable;