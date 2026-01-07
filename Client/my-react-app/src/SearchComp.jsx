import {useState, useEffect} from "react";
import TestImg from "/assets/testcard.png";
import ResultsComp from "./ResultsComp";
import FetchScryFallImg from "./ApiFetch"


// we want searht oonly be resposible for proceesing the input and passing it to a sister compoent for appending and fetching



function SearchComp({ScryFallUrl, setScryFallUrl, setLoading ,setError }) {

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

    (async () => {
      try {
        setLoading(true);
        setError(null);

        const res = await fetch(`http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(SubmittedCardName)}`);
        if (!res.ok) throw new Error(`HTTP ${res.status}`);

        // choose ONE:
         
         const resolved = await res.text(); // if your API returns plain text URL
        
        if (!ignore) setScryFallUrl(prev => [...prev, resolved]);
      } catch (e) {
        if (!ignore) setError(e.message ?? String(e));
      } finally {
        if (!ignore) setLoading(false);
      }
    })();

    return () => { ignore = true; };
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