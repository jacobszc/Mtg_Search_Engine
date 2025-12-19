

async function searchCards(query, colors,types) { // were calling an async function because inside we can use fetch, and while we wait for the fetch to resolve, the program wont pause
  
    // call your ASP.NET Core API

    
    
    const url = `/api/cardsearch/search?queryResult=${encodeURIComponent(query)}&colors=${encodeURIComponent(colors.join(','))}&types=${encodeURIComponent(types.join(','))}`;
    
    const response = await fetch(url); // ? start the query and qu is the name of the paramter 
       // so the above line says "in a thread, go the the fucntion decorated with the search label in mu controller, it will be named search"
       // and pass the paramter q to that function, and here ${... } is literal interpolation, jsut meaning use the value of whatevers inside as a string
       // finlay encodeuri jsut makes ure the query string doesnt contain any characters that would break the url
    
       if (!response.ok) { // if c# controller cuntion response was not succesful, it will return BADREQUEST aloong with "Query parameter 'queryResult' is required." response was returned from fetch so it is a Repsonse type object and respose.ok check is the boolen reposce member is ok
      const text = await response.text();// respone can be in josn, xml, string foramt etc... so grab the string version of the reponse.
      ResultDiv.innerHTML = `<p>Error: ${text}</p>`; // display " ERROR: Query parameter 'queryResult' is required. "
      return;
    }
    
    const card = await response.json(); // finaly if there was a query entered, and an OK reposnse returned, we make it here, and store the json of the card we requested, and is in the Response object body

    if (card.length === 0) { // if the length of the json list retuned is 0, 
      ResultDiv.innerHTML = "<p>No cards found.</p>"; //then it was succesful but no cards were found that match the query
      return;
    }

      showContent();

      


    
    
    
    
    
    // // use the below when you want to be able to display multiple cards
   

    // cards.forEach(card => { // for each enumerable json in out retunrted list of cards
    //   const div = document.createElement("div"); // create a new div and format it
    //   div.style.border = "1px solid #ccc";
    //   /*div.style.margin = "8px 0"; */
    //   /*div.style.padding = "8px"; */
    //   div.style.width = "200px";
    //   div.style.height = "250px";
      
      

    //   div.innerHTML = `
    //     <h3>${card.name}</h3>
    //     <ul>
    //       <li><b>Mana Cost:</b> ${card.ManaCost ?? "-"}</li>
    //       <li><b>Color Identity:</b> ${card.colorIdentity ?? "-"}</li>
    //       <li><b>Type:</b> ${card.type ?? "-"}</li>
    //       <li><b>Power/Toughness:</b> ${card.power ?? "-"} / ${card.toughness ?? "-"}</li>
    //       <li><b>ID:</b> ${card.id}</li>
    //     </ul>
    //   `;

    //   ResultDiv.appendChild(div); // makes div a child of reults div
    // });
  
}