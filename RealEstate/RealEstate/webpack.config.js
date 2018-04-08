var webpack = require('webpack');
var path = require('path');
var HtmlWebpackPlugin = require('html-webpack-plugin');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var helpers = require('./helpers');

module.exports = {
    entry: path.resolve(__dirname, 'src/main.ts'),
    devServer: {
        proxy: {
            '/api': {
                target: 'http://localhost:62393',
                secure: false
            }
        }
    },
    output: {
        path: path.resolve(__dirname, 'wwwroot'),
        filename: 'app.[hash].js'
    },
    module: {
        rules: [
            { test: /\.component.ts$/, loaders: 'angular2-template-loader' },
            { test: /\.ts$/, loaders: 'awesome-typescript-loader' },
            { test: /\.html$/, loaders: 'html-loader' },
            {
                test: /\.(css|scss)$/,
                loaders: ['to-string-loader'].concat(ExtractTextPlugin.extract({
                    fallback: "style-loader",
                    use: ['css-loader', 'scss-loader']
                }))
            }
        ]
    },
    resolve: {
        extensions: ['*', '.js', '.ts', '.html', '.css', '.scss']
    },
    plugins: [
        new webpack.LoaderOptionsPlugin({
            vue: {
                loaders: {
                    scss: 'style!css!sass'
                }
            }
        }),
        new HtmlWebpackPlugin({
            template: './src/index.html'
        }),
        new ExtractTextPlugin('./src/styles.css')
    ]
};