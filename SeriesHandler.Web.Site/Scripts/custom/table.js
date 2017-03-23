
function Series(title, year, id) {
    this.title = title;
    this.year = year;
    this.id = id;
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

var SingleSeries = React.createClass({

    displayName: "SingleSeries",
    propTypes: {
        title: React.PropTypes.string.isRequired
    },
    render: function () {
        return React.createElement(
            "tr", null,
            React.createElement("td", null, this.props.title),
            React.createElement("td", null, this.props.year)
        );
    }
});
