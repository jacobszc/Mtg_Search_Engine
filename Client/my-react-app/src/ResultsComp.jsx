
import TestImg from "/assets/testcard.png";
 /// delete below when test done ////




function ResultsComp({ScryFallUrl, loading, error }) { 

 /// resultImgList should be list of 

 if (loading) return <div>Loading…</div>;
  if (error) return <div style={{ color: "crimson" }}>{error}</div>;
  if (!ScryFallUrl) return <div>No image yet</div>;

 


 

   return (

   <div id = "results-div">
      
       { (ScryFallUrl) ? <img src = {ScryFallUrl} alt = "blank" className ="card-img"/> :  <pre>No cards loaded...</pre>   }
    
    </div>


       )
}

export default ResultsComp;