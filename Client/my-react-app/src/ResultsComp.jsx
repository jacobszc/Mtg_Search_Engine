import { useState } from "react";




function ResultsComp({ScryFallUrl , CardDescriptions }) { 

  //console.log(CardDescriptions.map(card => card.name));

  const[Hovered, setHovered] = useState(false);

  console.log("results comp" ,CardDescriptions)

 
  if (!ScryFallUrl) return <div>No image yet</div>;

  
  const CardDescriptionList = CardDescriptions.map((description) => <li key = {description[0].uuid}>{description[0].name}</li>)


 

   return (

   <div id="results-div">
    
  
    
    <div id = "image-half">
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
      />
    ))
  )}
</div>

{Hovered && (
  <div classname = "hover-box">
      
      
   <ul>{CardDescriptionList}</ul>
      


  </div>





)}



</div>

       )
}

export default ResultsComp;