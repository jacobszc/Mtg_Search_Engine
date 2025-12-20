function showDescription(cards) {
  let temp = document.getElementById("card-description-template");
  let clone = temp.content.cloneNode(true);
  /// clone is a div that contains an unorder list with 5 <li> elems//




  //1.) extact each memeber of cards and assin the values to clone.ul.l[i]
  const lis = clone.querySelectorAll("li");
  lis[0].textContent = cards[0].name;  // for now cards is a list of 1
  lis[1].textContent = cards[0].colorIdentity;
  lis[2].textContent = cards[0].manaValue;
  
  
  
   
  

  let results = document.getElementById("ResultDiv")
  results.appendChild(clone);
}

///////////////////////////////////////////////////////////////////

function showCardImage(urltoimg) {
//// create an img element that holds the uri to the card img
const img = document.createElement("img"); 
 img.src = urltoimg;
 img.alt = "Description of image";
 img.classList.add("result-img");
 img.width = "100%";
 img.height = "100%";
 
 

 ////// create a clone of a img result div and append the img to it as a child
 let temp = document.getElementById("card-image-template");
 let clone = temp.content.cloneNode(true);

 let imgContainer = clone.querySelector("#imgResultDiv");
 imgContainer.appendChild(img);

 

 //// appaend the clone with img as child to reults div
 
  let results = document.getElementById("ResultDiv");
  results.appendChild(imgContainer);



 




}