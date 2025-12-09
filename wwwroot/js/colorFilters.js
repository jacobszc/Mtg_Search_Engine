
function filterColors() {

const GreenCheckBox = document.getElementById("checkbox-green")
const BlackCheckBox = document.getElementById("checkbox-black")

let colorFilter =[];



 
if(GreenCheckBox.checked) {
    colorFilter.push("G");
}

if(BlackCheckBox.checked) {

    colorFilter.push("B");
}


return colorFilter;

} 


