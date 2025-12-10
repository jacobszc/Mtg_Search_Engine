
function filterColors() {


const WhiteCheckBox = document.getElementById("checkbox-white")  
const BlueCheckBox = document.getElementById("checkbox-blue")
const BlackCheckBox = document.getElementById("checkbox-black")
const RedCheckBox = document.getElementById("checkbox-red")
const GreenCheckBox = document.getElementById("checkbox-green")
const ColorlessCheckBox = document.getElementById("checkbox-colorless")

let colorFilter =[];

if(WhiteCheckBox.checked) {

    colorFilter.push("W")
}

if(BlueCheckBox.checked) {

    colorFilter.push("U")
}

if(BlackCheckBox.checked) {

    colorFilter.push("B");
}

 
if(RedCheckBox.checked) {

    colorFilter.push("R")
}

if(GreenCheckBox.checked) {
    colorFilter.push("G");
}

if(ColorlessCheckBox.checked){

    colorFilter.push("C")
}




return colorFilter;

} 


