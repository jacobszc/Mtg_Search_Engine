import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'
import TestImg from "./assets/testcard.png"


function App() {

 
  

  return  (
   
    <div class = "centered-content">

     <SearchComp/>
     <ColorFilterComp />
     <ResultsComp url = {TestImg}/>




    </div>  

    
  )
  
}



export default App
