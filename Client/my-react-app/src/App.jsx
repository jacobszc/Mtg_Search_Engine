import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'




function App() {
  

const [ScryFallUrl, setScryFallUrl] = useState([]);
const [backEndApiUrl, setBackEndApiUrl ] = useState([]);
const [CardDescriptions, setCardDescriptions] = useState([]);
//const [backEndApiUrl, setBackEndApiUrl] = useState("http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=");

  
  


 
 

  return  (
   
    <div class = "centered-content">

    <SearchComp  ScryFallUrl = {ScryFallUrl} setScryFallUrl = {setScryFallUrl} CardDescriptions={CardDescriptions}  setCardDescriptions = {setCardDescriptions} />
     
    <ColorFilterComp />
     
    <ResultsComp ScryFallUrl = {ScryFallUrl} CardDescriptions = {CardDescriptions} />



    </div>  

    
  )
  
}



export default App
