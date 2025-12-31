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

  const temp = [red, green]; 
  const para = <p value = {temp} onChange = {handleChange}></p>

  const [Images, setImages] = useState(temp); // images in an initialy empty array

  function handleChange(e) {

    setImages(prev => [...prev,url])
  }




 return (

  

       
       <div id = "results-div">

        {Images.map(image => <img key={image} src = {Images} alt = "blank img" className ="card-img"/>
        
        
        )}


        

          
         

      </div>


    )
}

export default ResultComp;