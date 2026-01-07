
import TestImg from "/assets/testcard.png";
 /// delete below when test done ////




function ResultsComp({ScryFallUrl, loading, error }) { 

 /// resultImgList should be list of 

 if (loading) return <div>Loading…</div>;
  if (error) return <div style={{ color: "crimson" }}>{error}</div>;
  if (!ScryFallUrl) return <div>No image yet</div>;

 


 

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
      />
    ))
  )}
</div>

       )
}

export default ResultsComp;