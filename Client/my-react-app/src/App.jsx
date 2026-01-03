import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'



function App() {

 
  
  
  const [urltoImg, seturltoImg] = useState("")

 
 

  return  (
   
    <div class = "centered-content">

     <SearchComp urltoImg={urltoImg} seturltoImg={seturltoImg}/>
     <ColorFilterComp />
     <ResultsComp urltoImg={urltoImg} />



    </div>  

    
  )
  
}



export default App
