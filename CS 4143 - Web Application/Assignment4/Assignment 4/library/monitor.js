var w = window.innerWidth
|| document.documentElement.clientWidth
|| document.body.clientWidth;

var h = window.innerHeight
|| document.documentElement.clientHeight
|| document.body.clientHeight;

var x = document.getElementById("demo");
x.innerHTML = "Browser inner window width: " + w + ", height: " + h + ".";

document.getElementById("demo2").innerHTML = 
"Screen width is " + screen.width;

document.getElementById("demo3").innerHTML = 
"Screen height is " + screen.height;