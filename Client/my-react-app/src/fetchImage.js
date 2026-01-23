
async function fetchImage(SubmittedCardName) {


const res = await fetch(`http://localhost:5221/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(SubmittedCardName)}`);

const resolved = await res.text();


return resolved;


}

export default fetchImage;