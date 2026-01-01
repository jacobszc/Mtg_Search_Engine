import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'



function App() {

 
  
  
  const [resultImgList, setResultImgList] = useState([]);

 
 

  return  (
   
    <div class = "centered-content">

     <SearchComp  setResultImgList = {setResultImgList}/>
     <ColorFilterComp />
     <ResultsComp resultImgList = {resultImgList} />



    </div>  

    
  )
  
}



export default App
