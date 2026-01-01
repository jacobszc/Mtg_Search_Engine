
import TestImg from "/assets/testcard.png";
 /// delete below when test done ////




function ResultComp({resultImgList}) { 

 /// resultImgList should be list of 

 

  const ListItems = resultImgList.map((url) => <img key = "url" src = {url} alt = "blank" className ="card-img"/>)
 

  

  




 return (

  

       
       <div id = "results-div">

        
        {ListItems}
        

          
         

      </div>


    )
}

export default ResultComp;