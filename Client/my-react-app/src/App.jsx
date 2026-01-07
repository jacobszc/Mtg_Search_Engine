import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'



function App() {
  

const [ScryFallUrl, setScryFallUrl] = useState([]);
const [loading, setLoading] = useState(false);
const [error, setError] = useState(null);
//const [backEndApiUrl, setBackEndApiUrl] = useState("http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=");

  
  


 
 

  return  (
   
    <div class = "centered-content">

    <SearchComp  ScryFallUrl = {ScryFallUrl} setScryFallUrl = {setScryFallUrl} setLoading ={setLoading} setError = {setError} />
     
    <ColorFilterComp />
     
    <ResultsComp ScryFallUrl = {ScryFallUrl} error={error} loading = {loading}/>



    </div>  

    
  )
  
}



export default App
