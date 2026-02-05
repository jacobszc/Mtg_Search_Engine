import { useState } from "react";




function ResultsComp({ScryFallUrl , CardDescriptions }) { 

  //console.log(CardDescriptions.map(card => card.name));

  const[Hovered, setHovered] = useState(false);
  const[Deck, setDeck] = useState([]);
  

  /// function to add img to list and console log it


  function handleClick(url) {

    setDeck(prev => [...prev, url]);
    console.log("you added: ", {url}, "to your deck!");
    


  }
 

 
  if (!ScryFallUrl) return <div>No image yet</div>;

  
  const CardDescriptionList = CardDescriptions.map((description) => <li key = {description[0].uuid}>{description[0].name}</li>)


 

   return (

   <div id="results-div">
    
  
    
   
  {ScryFallUrl.length === 0 ? (
    <pre>No cards loaded...</pre>
  ) : (
    ScryFallUrl.map((url, index) => (
      <img
        key={index}
        src={url}
        alt="card"
        className="card-img"
        onMouseEnter={() => setHovered(true)}
        onMouseLeave={() => setHovered(false)}
        onClick={() => handleClick(url)}
      />
    ))
  )}


{Hovered && (
  <p>click img to add to deck!</p>





)}



</div>

       )
}

export default ResultsComp;