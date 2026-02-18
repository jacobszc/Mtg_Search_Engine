import { useState } from "react";




function ResultsComp({ScryFallUrl , CardDescriptions, Deck, setDeck }) { 

  //console.log(CardDescriptions.map(card => card.name));

  const[Hovered, setHovered] = useState(false);
  
  

  /// function to add img to list and console log it


  function handleClick(ScryFallUrl) {

    setDeck(prev => [...prev, ScryFallUrl]);
    
    


  }
 

 
  if (!ScryFallUrl) return <div>No image yet</div>;

  
  const CardDescriptionList = CardDescriptions.map((description) => <li key = {description[0].uuid}>{description[0].name}</li>)


 

   return (

   <div id="results-div">
    
  
    
   
  {ScryFallUrl.length === 0 ? (
    <pre>No cards loaded...</pre>
  ) : (

    <img src = {ScryFallUrl}
    alt="card"
    className="card-img"
    onMouseEnter={() => setHovered(true)}
    onMouseLeave={() => setHovered(false)}
    onClick={() => handleClick(ScryFallUrl)}></img>
   
  )}


{Hovered && (
  <p>click img to add to deck!</p>





)}



</div>

       )
}

export default ResultsComp;