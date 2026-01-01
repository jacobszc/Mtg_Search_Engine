import {useRef, useEffect, useState} from 'react';
import TestImg from "./assets/testcard.png";
 /// delete below when test done ////
import blue from "./assets/manasymbols/blue.png";
import black from "./assets/manasymbols/black.png";
import green from "./assets/manasymbols/green.png";
import red from "./assets/manasymbols/red.png";
import white from "./assets/manasymbols/white.png";
import colorless from "./assets/manasymbols/colorless.png";




function ResultComp({resultImgList, setResultImgList}) { 

 
 
 

  const ListItems = resultImgList.map(url => <img key ={url} src = {url} alt = "blank" className ="card-img"/>)
 

  

  




 return (

  

       
       <div id = "results-div">

        
        {ListItems}
        

          
         

      </div>


    )
}

export default ResultComp;