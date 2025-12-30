import {useRef, useEffect, useState} from 'react';
import TestImg from "./assets/testcard.png";
 /// delete below when test done ////
import blue from "./assets/manasymbols/blue.png";
import black from "./assets/manasymbols/black.png";
import green from "./assets/manasymbols/green.png";
import red from "./assets/manasymbols/red.png";
import white from "./assets/manasymbols/white.png";
import colorless from "./assets/manasymbols/colorless.png";




function ResultComp(props) { 

  //const [ImagesList, updateImagesList] = useState([]);


  const ImagesList = [blue, black, red, green, white, colorless];



 return (

       
       <div id = "results-div">

        {ImagesList.map(image =>
          <img key={image} src = {image} alt = "blank img" className ="card-img"/>
        
        
        )}


        

          
         

      </div>


    )
}

export default ResultComp;