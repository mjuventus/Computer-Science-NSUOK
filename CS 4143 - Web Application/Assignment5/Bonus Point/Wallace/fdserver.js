const express = require('express');
const mongoIO = require('./io.js');
const bodyParser = require('body-parser');
const app = express();
const port = 4000;



function sendIt()
{
    window.alert("Thank you, we will get to you soon");
    document.getElementById("name").value = "";
    document.getElementById("email").value = "";
    document.getElementById("phone").value = "";
    document.getElementById("message").value = "";
}



app.use(express.static('public'));
app.use(express.static('public/pages'));



app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json())
app.get('/', function(req, res) {
res.redirect('pages/index.html');
})
function PostfeedbackAPI(req, res, next) 
{
console.log(req.body);
var Write = [{'name': req.body.name, 'email': req.body.email, 'phone': req.body.phone, 'message': req.body.message}];
try{
mongoIO.writeItem(Write)
} catch (err) {
next(err);
}

}
app.post('/fbuser', PostfeedbackAPI)

app.listen(port, function() {console.log(`Wallace Finance listening on port ${port}!`)})
