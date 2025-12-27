import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'


function App() {
  

  return  (
   
    <div class = "centered-content">

    
     <SearchComp/>
     <ColorFilterComp />
     <ResultsComp />




    </div>  

    
  )
  
}

export default App
