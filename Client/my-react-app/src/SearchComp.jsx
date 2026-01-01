import {forwardRef, useRef, useState } from "react";
import TestImg from "./assets/testcard.png";
import ResultComp from "./ResultsComp";
import magglass from "./assets/mag-glass.png" ;



function SearchComp({resultImgList, setResultImgList}) {
  
    const[input, setInput] = useState("");
    

    
    return (

  

     <div id= "input-wrapper">

       
    
    <input 
      
        id="input-bar" 
        type="text" 
        placeholder="Enter card name (e.g., Sakura Tribe Elder)"
        value = {input}
        onChange = {(e)=> setInput(e.target.value)}
    />

  <button id="search-button" onClick = {()=> setResultImgList(prev => [...prev, input])}> 
        click 
    </button>

    {/* <p>{resultImageList}</p> */}

  
  
  </div>
    
    
  
  
  


    )


    }


export default SearchComp;