import {useState, useEffect} from "react";
import TestImg from "/assets/testcard.png";
import ResultsComp from "./ResultsComp";
import {fetchImage, fetchDescription } from "./FetchContent";


// we want searht oonly be resposible for proceesing the input and passing it to a sister compoent for appending and fetching



function SearchComp({ScryFallUrl, setScryFallUrl, setCardDescriptions }) {

const [Input, setInput] = useState("");
const [SubmittedCardName, setSubmittedCardName] = useState(null);



console.log("search comp entered and Scryfallurl is...: " , {ScryFallUrl})

 function onSubmit(e) {
  e.preventDefault();
  const q = Input.trim();
  if(!q) return;
  console.log("your on submit function has been called and the value is", {q})
  setSubmittedCardName(q)
   

 }

  
  
useEffect(() => {
    if (!SubmittedCardName) return;

    let ignore = false; // prevents setting state after unmount / stale fetch
     
   fetchDescription(SubmittedCardName).then(resolved => {

   if(!ignore) { setCardDescriptions(prev => [...prev, resolved])}

    

   })
   
   
    fetchImage(SubmittedCardName).then(resolved => {

    if (!ignore) setScryFallUrl(prev => [...prev, resolved]);
  

   });


   
      
      

    return () =>  ignore = true; 
  
  
  }, [SubmittedCardName]);

  return (

  <div id= "input-wrapper">
    <form onSubmit = {onSubmit}>
    <input 
        id="input-bar" 
        type="text" 
        placeholder="Enter card name (e.g., Sakura Tribe Elder)"
        value = {Input}
        onChange = {(e)=> setInput(e.target.value)}
    />

    <button id="search-button"> search!</button>
     </form>
   
  </div>
    
    )


  }


export default SearchComp;