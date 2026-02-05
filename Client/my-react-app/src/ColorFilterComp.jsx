import blue from "/assets/manasymbols/blue.png";
import black from "/assets/manasymbols/black.png";
import green from "/assets/manasymbols/green.png";
import red from "/assets/manasymbols/red.png";
import white from "/assets/manasymbols/white.png";
import colorless from "/assets/manasymbols/colorless.png";
import DropdownComp from './DropDownTypeComp'

function ColorFilterComp() {



    return (

        <div className = "filter-row">  


  <div className="check-box-container"> 

    <div className="check-row">
    <img src = {white} alt = "blue" width = {25} height = {20}></img>
    <span className = "checkboxes"> 
    <input type="checkbox" id="checkbox-white"/>
    </span>
  </div>

  <div className="check-row">
    <img src = {blue} alt = "blue" width = {25} height = {20}></img>
    <span className = "checkboxes"> 
    <input type="checkbox" id="checkbox-blue"/>
    </span>
  </div>

  <div className="check-row">
    <img src = {black} alt = "blue" width = {25} height = {20}></img>
    <span className = "checkboxes"> 
    <input type="checkbox" id="checkbox-black"/>
    </span>
  </div>

  <div className="check-row">
    <img src = {red} alt = "blue" width = {25} height = {20}></img>
    <span className = "checkboxes"> 
    <input type="checkbox" id="checkbox-red"/>
    </span>
  </div>

  <div className="check-row">
     <img src = {green} alt = "blue" width = {25} height = {20}></img>
     <span className = "checkboxes">
     <input type="checkbox" id="checkbox-green"/> 
     </span>
  </div>

  <div className="check-row">
     <img src = {colorless} alt = "blue" width = {25} height = {20}></img>
     <span className = "checkboxes">
     <input type="checkbox" id="checkbox-colorless"/> 
     </span>
  </div>




</div>

 <DropdownComp />
</div> // end filter row






    )
}

export default ColorFilterComp;