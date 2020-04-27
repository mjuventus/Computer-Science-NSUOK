
const MongoClient = require('mongodb').MongoClient;
const mongoURL = require('./url');
const collectionName = 'User_info';
function writeItem(data) {
const client = new MongoClient(mongoURL.url, { useNewUrlParser: true }, { useUnifiedTopology: true });
client.connect(function(err) {

if (err) {
console.log('Connection error!');
throw new Error(err);
}
const collection = client.db("Form_Feedback").collection(collectionName);
if (Array.isArray(data)) {
collection.insertMany(data);
} else {
collection.insertOne(data);
}
client.close();
})
}
exports.writeItem = writeItem