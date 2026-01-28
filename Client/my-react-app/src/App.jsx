import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'
import BackgroundComp from './BackgroundComp'




function App() {
  

const [ScryFallUrl, setScryFallUrl] = useState([]);

const [CardDescriptions, setCardDescriptions] = useState([]);


console.log("this is in app" , CardDescriptions)
//const [backEndApiUrl, setBackEndApiUrl] = useState("http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=");

  
  


 
 

  return  (
    

       <BackgroundComp>
    
   
    <div class = "centered-content">

   

    <SearchComp  ScryFallUrl = {ScryFallUrl} setScryFallUrl = {setScryFallUrl}  setCardDescriptions = {setCardDescriptions} />
     
    <ColorFilterComp />
     
    <ResultsComp ScryFallUrl = {ScryFallUrl} CardDescriptions = {CardDescriptions} />



    </div> 

    </BackgroundComp>

    

    
  )
  
}



export default App
