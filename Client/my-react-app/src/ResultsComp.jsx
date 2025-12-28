import {useRef, useEffect} from 'react';
import ImgComp from './ImgComp';
function ResultComp(props) { // pass the button and 

  const inputElement = useRef(); // refence to the div where we want to show the img
   
  const focusInput = () => {

     inputElement.current.focus(); /// make the i9mg div the current focus so we can refence it
  }
  

    return (

        <div id = "results-div">

          

         
         


        </div>


    )
}

export default ResultComp;