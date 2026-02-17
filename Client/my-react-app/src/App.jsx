import { useState } from 'react'
import SearchComp from './SearchComp'
import ColorFilterComp from './ColorFilterComp'
import './App.css'
import ResultsComp from'./ResultsComp'
import BackgroundComp from './BackgroundComp'
import DeckStack from './Deckstack'




function App() {
  

const [ScryFallUrl, setScryFallUrl] = useState();

const [CardDescriptions, setCardDescriptions] = useState([]);

const[Deck, setDeck] = useState([]);


console.log("this is in app" , CardDescriptions)
//const [backEndApiUrl, setBackEndApiUrl] = useState("http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=");

  
  


 
 

  return  (
    

       
    <div className ="background">

      <BackgroundComp/>
   
    <div className = "centered-content">

   

    <SearchComp  ScryFallUrl = {ScryFallUrl} setScryFallUrl = {setScryFallUrl}  setCardDescriptions = {setCardDescriptions} />
     
    <ColorFilterComp />
     
    <ResultsComp ScryFallUrl = {ScryFallUrl} CardDescriptions = {CardDescriptions} Deck = {Deck} setDeck = {setDeck}/>

    <DeckStack Deck = {Deck}/>



    </div> 

    
  </div>
    

    
  )
  
}



export default App
