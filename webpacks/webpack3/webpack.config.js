module.exports={
    entry:"./src/app.js",
    mode:"development",
    output:{
        path:__dirname+"/public",
        filename:"bundle.js"
    },
    devServer:{
        contentBase:__dirname+"/public",
        port:3201
    },
    module:{
        rules:[
                {
                    loader:"babel-loader",
                    test:/\.js/
                },
                {
                    test:/\.s?css/,
                    use:[{
                        loader: "style-loader" // creates style nodes from JS strings
                    }, {
                        loader: "css-loader" // translates CSS into CommonJS
                    }, {
                        loader: "sass-loader" // compiles Sass to CSS
                    }]
                },
                {
                    test: /\.(gif|png|jpe?g|svg)$/i,
                    use: [
                      'file-loader',
                      {
                        loader: 'image-webpack-loader',
                        options: {
                          mozjpeg: {
                            progressive: true,
                            quality: 65
                          },
                          // optipng.enabled: false will disable optipng
                          optipng: {
                            enabled: false,
                          },
                          pngquant: {
                            quality: '65-90',
                            speed: 4
                          },
                          gifsicle: {
                            interlaced: false,
                          },
                          // the webp option will enable WEBP
                          webp: {
                            quality: 75
                          }
                        }
                      },
                    ],
                }
        ]
    }
};