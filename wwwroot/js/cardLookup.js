const InputBar = document.getElementById('InputBar')  
const SearchButton = document.getElementById('SearchButton')


//// the above varioables will hold references within the DOm to the html elemetns, NOT THE VALUES


SearchButton.addEventListener("click", () => {   // add event listener to my button that when cliked, calls a lambda function 
  const colors = filterColors();
  const types = filterTypes();
  
  
  const query = InputBar.value.trim(); // define a query variable to store user input. input.value is the value givent o my input div in my html.
  if (!query) {                     // trim removes the white space and new lines from beginigna nd end of string but not the middle.
    ResultDiv.innerHTML = "<p>Please enter a card name.</p>"; // inner html is a string that represents all the html inside an elemtn.
    // the search bar is empty when the ubton is lciked, the empty reult div will now contain the string, PLEASE NETER CARD NAME
    return; // exit lambda if ther eis no query
  }
  searchImg(query);
  searchCards(query, colors, types); // in the case there in a valid query enterted, call searchCards
});



