


function SearchComp() {
  
    const print = () => {
        console.log("button clicked!")
    }

    return (

    <div id="searchbar-row">
    <input id="input-bar" type="text" placeholder="Enter card name (e.g., Sakura Tribe Elder)" />
    <button id="search-button" onClick = {print} >Search</button>
   </div>



    )


    }


export default SearchComp;