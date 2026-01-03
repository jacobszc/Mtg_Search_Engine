import { useState } from "react";
import TestImg from "/assets/testcard.png";
import ResultComp from "./ResultsComp";






function SearchComp({urltoImg, seturltoImg }) {

  
 

 
 const [input, setInput] = useState("");  /// dynamcily keep track of user inpuit
  // stsae machine to update if the data was fecthed proplety
 
 
 
  
  
  
  
    

    
    return (

  

     <div id= "input-wrapper">

       
    
    <input 
      
        id="input-bar" 
        type="text" 
        placeholder="Enter card name (e.g., Sakura Tribe Elder)"
        value = {input}
        onChange = {(e)=> setInput(e.target.value)}
    />

  <button id="search-button" onClick = {()=> seturltoImg(`http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=${input}`)}> 
    {/* need () => otherwise react wil call setResultImgList immediatly and assin the return to the button  */}
        click 
    </button>

    {/* <p>{resultImageList}</p> */}

  
  
  </div>
    
    
  
  
  


    )


    }


export default SearchComp;