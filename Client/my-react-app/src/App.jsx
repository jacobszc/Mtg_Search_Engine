import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'
import TestImg from "./assets/testcard.png"


function App() {

 
  
  
  const [resultImgList, setResultImgList] = useState([]);

 
  

  return  (
   
    <div class = "centered-content">

     <SearchComp resultImgList ={resultImgList} setResultImgList = {setResultImgList}/>
     <ColorFilterComp />
     <ResultsComp resultImgList ={resultImgList} setResultImgList = {setResultImgList}/>



    </div>  

    
  )
  
}



export default App
