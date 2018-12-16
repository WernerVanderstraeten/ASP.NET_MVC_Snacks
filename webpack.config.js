const path = require('path');

// webpack.config.js 
module.exports = {
    entry: { main: './src/customer/index.js' },
    output: {
        path: path.resolve(__dirname, 'wwwroot'),
        filename: 'customer.js'
    }
};
