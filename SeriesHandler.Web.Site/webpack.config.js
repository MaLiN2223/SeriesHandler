/// <binding BeforeBuild='Run - Production, Run - Development' />
var webpack = require('webpack');
var path = require('path'); 

var BUILD_DIR = path.resolve(__dirname, 'wwwroot/client-js/');
var APP_DIR = path.resolve(__dirname, 'wwwroot/js/');

var config = {
    entry: { 
        series:APP_DIR + "/series/index.jsx"
    },
    output: {
        path: path.join(__dirname, 'wwwroot/client-js/'),
        filename: "[name].js"
    },
    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    externals: {
        'react': 'React'
    },
    resolve: {
        extensions: ['.js', '.jsx']
    }
};

module.exports = config;