import { useState, useEffect } from "react";
import TestImg from "/assets/testcard.png";
 /// delete below when test done ////




function ResultComp({urltoImg, seturltoImg}) { 

 /// resultImgList should be list of 
const [dataIsLoaded, setdataIsLoaded ] = useState(false);
 

  //const ListItems = urltoImg.map((url) => <img key = "url" src = {url} alt = "blank" className ="card-img"/>)
 
 useEffect(() =>{

   

  // only fetch if it's your backend route, not a direct https image url
  console.log("fetching:", urltoImg);
     fetch(urltoImg)
    .then((response)=> response.text()) // response is an unroslved promise to some text
     .then((text) => {
       seturltoImg(text);
       setdataIsLoaded(true);
       console.log("mounted...")});

    

    return () => {
        console.log("unmounted...")

    }

    }); // pass url as a depeendecy. use effect will get called every time url changes
  

   




 return (

  

       
       <div id = "results-div">

        
        <img src = {urltoImg} alt = "blank" className ="card-img"/>
        

          
         

      </div>


    )
}

export default ResultComp;