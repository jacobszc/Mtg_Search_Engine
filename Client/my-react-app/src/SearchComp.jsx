import { useState } from "react";
import TestImg from "/assets/testcard.png";
import ResultComp from "./ResultsComp";





function SearchComp({setResultImgList}) {
  
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
    {/* need () => otherwise react wil call setResultImgList immediatly and assin the return to the button  */}
        click 
    </button>

    {/* <p>{resultImageList}</p> */}

  
  
  </div>
    
    
  
  
  


    )


    }


export default SearchComp;