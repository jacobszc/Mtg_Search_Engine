import { useState, useEffect } from "react";
import TestImg from "/assets/testcard.png";
import ResultComp from "./ResultsComp";






function SearchComp() {

  
 

 const [urltoImg, seturlToImg] = useState("")
 const [input, setInput] = useState("");  /// dynamcily keep track of user inpuit
 const [dataIsLoaded, setdataIsLoaded ] = useState(false); // stsae machine to update if the data was fecthed proplety
 
 
 
  
   useEffect( () =>{
    fetch(urltoImg)
    .then((response)=> response.text()) // response is an unroslved promise to some text
    .then((text) => {
       seturlToImg(text);
      setdataIsLoaded(true);
     

    });

   
  
  }, [urltoImg]); // pass url as a depeendecy. use effect will get called every time url changes
  
  if(!dataIsLoaded) {
    return (

      <div> <h1>Please wait some time....</h1></div>

     )} // end if check for loading data
    

    
    return (

  

     <div id= "input-wrapper">

       
    
    <input 
      
        id="input-bar" 
        type="text" 
        placeholder="Enter card name (e.g., Sakura Tribe Elder)"
        value = {input}
        onChange = {(e)=> setInput(e.target.value)}
    />

  <button id="search-button" onClick = {()=> seturlToImg(`/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent({input})}`)}> 
    {/* need () => otherwise react wil call setResultImgList immediatly and assin the return to the button  */}
        click 
    </button>

    {/* <p>{resultImageList}</p> */}

  
  
  </div>
    
    
  
  
  


    )


    }


export default SearchComp;