
var mongoose = require('mongoose');
var mongoDB = 'mongodb://127.0.0.1:27017';
mongoose.connect(mongoDB, { useNewUrlParser: true });
var db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error:'));