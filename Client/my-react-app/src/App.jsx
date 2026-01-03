import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'



function App() {

 const [display, setDisplay] = useState(true);
  
  
  const [urltoImg, seturltoImg] = useState('')

 
 

  return  (
   
    <div class = "centered-content">

    <SearchComp urltoImg={urltoImg} seturltoImg={seturltoImg}/>
     
     <ColorFilterComp />
     
     {display && <ResultsComp urltoImg={urltoImg} seturltoImg={seturltoImg} />}



    </div>  

    
  )
  
}



export default App
