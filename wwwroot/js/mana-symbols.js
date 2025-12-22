function getManaSymbolDiv(ManaCost){
  const DescriptionDiv =  document.getElementById("DescriptionDiv");
    // givena string with digits and characters, convert each character into
    //correspoding mana symbol image and display


    /// clean manacost to get rtid of {} as well as white space for parsing

    const cleanedManaCost = ManaCost.replace(/[{}]/g, "").trim();


    let temp = document.getElementById("mana-symbol-container-template");
    let clone = temp.content.cloneNode(true);

    console.log("mana-symbol-container contains", clone.childElementCount, " elements");

    let symbolcontainer = clone.getElementById("mana-symbol-container");

    console.log("mana-symbol-container contains", symbolcontainer.childElementCount, " elements");

    //DescriptionDiv.appendChild(symbolcontainer);




    const lis = symbolcontainer.querySelectorAll(".mana-symbol");
    let count = 0;

    //clone is now the div that contains 10 empty divs to display the mana sybols

   for(const char of cleanedManaCost) {


    switch(char) {

        case 'W':

        const imgW = document.createElement("img");
        const uritoimgW = "assets/manasymbols/white.png";

        imgW.src = uritoimgW;
        imgW.width = "100%";
        imgW.height = "100%";
        imgW.alt = "white";
        imgW.classList.add("white-symbol");
        lis[count].appendChild(imgW);
        count ++;
        break;
 //////////////////////////////////////////////////////////////////////

  case 'G':

        const imgG = document.createElement("img");
        const uritoimgG = "assets/manasymbols/green.png";

        imgG.src = uritoimgG;
        imgG.width = "100%";
        imgG.height = "100%";
        imgG.alt = "green";
        imgG.classList.add("green-symbol");
        lis[count].appendChild(imgG);
        count ++;
        break;
 //////////////////////////////////////////////////////////////////////

 case 'U':

        const imgU = document.createElement("img");
        const uritoimgU = "assets/manasymbols/blue.png";

        imgU.src = uritoimgU;
        imgU.style.width = "100%";
        imgU.style.height = "100%";
        imgU.alt = "blue";
        imgU.classList.add("blue-symbol");
       
        lis[count].appendChild(imgU);
        count ++;
        break;
 //////////////////////////////////////////////////////////////////////

 case 'B':

        const imgB = document.createElement("img");
        const uritoimgB = "assets/manasymbols/black.png";

        imgB.src = uritoimgB;
        imgB.width = "100%";
        imgB.height = "100%";
        imgB.alt = "black";
        imgB.classList.add("black-symbol");
        lis[count].appendChild(imgB);
        count ++;
        break;
 //////////////////////////////////////////////////////////////////////

 case 'R':

        const imgR = document.createElement("img");
        const uritoimgR = "assets/manasymbols/red.png";

        imgR.src = uritoimgR;
        imgR.width = "100%";
        imgR.height = "100%";
        imgR.alt = "red";
        imgR.classList.add("red-symbol");
        lis[count].appendChild(imgR);
        count ++;
        break;
 //////////////////////////////////////////////////////////////////////

        default: 
        // if its not a char its a number, so jsut display the number

        lis[count].textContent = char;
        count ++;


        
        break;
    }
    
   };

   return clone; // return the div that contains the sequential mana symbols

}