




function ResultsComp({ScryFallUrl , CardDescriptions }) { 

  //console.log(CardDescriptions.map(card => card.name));

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
      />
    ))
  )}
</div>
<div id= "description-half">
  

 {CardDescriptions.length === 0  ? (<pre>No Descritions Avalible</pre>) : ( <ul>{CardDescriptionList}</ul>)}
  

</div>
</div>

       )
}

export default ResultsComp;