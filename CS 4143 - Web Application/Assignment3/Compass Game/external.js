//compass game
{var toptext = new String();
	var lefttext = new String();
	var righttext = new String();
	var bottomtext = new String();
	var directions = new Array();
	var tempArray = new Array();
    var u;
	
	
	directions[4] = "N";
	directions[1] = "S";
	directions[2] = "E";
	directions[3] = "W";
	
	
  function restartCompass(form) {
    form.reset();
    document.getElementById("top").innerHTML = "";
    document.getElementById("left").innerHTML = "";
    document.getElementById("right").innerHTML = "";
    document.getElementById("bottom").innerHTML = "";

    form.elements["topBox"].disabled = false;
    form.elements["leftBox"].disabled = false;
    form.elements["rightBox"].disabled = false;
    form.elements["bottomBox"].disabled = false;
    form.elements["update"].disabled = false;
    form.elements["ScrambleCompass"].disabled = true;
  } // end restartCompass

  //****************************

  // This function copies the text box values to the compass's
  // directions and disables the text boxes and update button.
	
	function ScrambleCompass(form) {
    
	var i;	
	for (i = 1; i < 5; i++)
		{
			tempArray[i] = (Math.floor(Math.random() * 4)+1);
			if(i > 1)
			{
			if ((tempArray[i] == tempArray[i-1]) || (tempArray[i] == tempArray[i-2]) || (tempArray[i] == tempArray[i-3]))
                while((tempArray[i] == tempArray[i-1]) || (tempArray[i] == tempArray[i-2]) || (tempArray[i] == tempArray[i-3]))
                    {
                        tempArray[i] = (Math.floor(Math.random() * 4)+1);
                    }
			}
            
            u = tempArray[i];
            
            
		}//
		
	toptext = directions[tempArray[4]];
	bottomtext = directions[tempArray[1]];
	righttext = directions[tempArray[2]];
	lefttext = directions[tempArray[3]];
	
		
    document.getElementById("top").innerHTML = toptext;
    document.getElementById("left").innerHTML = lefttext;
    document.getElementById("right").innerHTML = righttext;
    document.getElementById("bottom").innerHTML = bottomtext;
		
		    
  }
	
	
	

 function updateCompass(form) 
 {
      document.getElementById("top").innerHTML =
      form.elements["topBox"].value;
      document.getElementById("left").innerHTML =
      form.elements["leftBox"].value;
      document.getElementById("right").innerHTML =
      form.elements["rightBox"].value;
      document.getElementById("bottom").innerHTML =
      form.elements["bottomBox"].value;

      directions[4] = form.elements["topBox"].value;
      directions[1] = form.elements["leftBox"].value;
      directions[2] = form.elements["rightBox"].value;
      directions[3] = form.elements["bottomBox"].value;
	  
      form.elements["topBox"].disabled = true;
      form.elements["leftBox"].disabled = true;
      form.elements["rightBox"].disabled = true;
      form.elements["bottomBox"].disabled = true;
      form.elements["update"].disabled = true;
  } // end updateCompass

  //****************************

  // This function swaps the direction letters for the
  // 2 passed-in positions.

  function swap(direction1, direction2) {
    var temp;  // holds direction during swap process
    temp = document.getElementById(direction1).innerHTML;
    document.getElementById(direction1).innerHTML =
      document.getElementById(direction2).innerHTML;
    document.getElementById(direction2).innerHTML = temp;
  } // end swap
}




//clicker game

// JavaScript Document