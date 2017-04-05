"use strict";

module.exports = {
    entry: {
        //main: "./index.js",
        series: "./Scripts/custom/series/index.js"
    }
    ,
    output: {
        filename: "Scripts/custom/[name]-bundle.js"
    },
    module: {
        loaders: [
            {
                test: /\.js$/,
                loader: "babel-loader",
                exclude: /node_modules/,
                query: {
                    presets: ["es2015", "react"]
                }
            },
            {
                test: /\.css$/,
                loader: "style-loader!css-loader"
            },
        ]
    }
};