
export async function fetchImage(SubmittedCardName) {


const res = await fetch(`http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(SubmittedCardName)}`);

const resolved = await res.text();


return resolved;


}




export async function fetchDescription(SubmittedCardName) {


     const res = await fetch(`http://localhost:5221/api/cardsearch/search?queryResult=${encodeURIComponent(SubmittedCardName)}`);
      
     const resolved = await res.json();
    
     return resolved; // resolved is a promimse that will unpack to a list of json objects representing cards
}

