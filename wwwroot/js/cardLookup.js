const input = document.getElementById('cardName')
const button = document.getElementById('searchBtn')
const result = document.getElementById('result')

async function lookup() {
  console.log("lookup() called!");


  const name = input.value.trim();
  if (!name) {
    result.innerHTML = '<p class="not-found">Please enter a card name.</p>';
    return;
  }

  result.textContent = 'Searching...';

  try {
    const res = await fetch(`/api/cards/${encodeURIComponent(name)}`); //<-- so this appends api/cards after my http://localcost//5000 and then the card name they search for after that
    if (res.status === 404) {
      result.innerHTML = `<p class="not-found">No card named "<b>${name}</b>" was found.</p>`;
      return;
    }
    if (!res.ok) {
      result.innerHTML = `<p class="not-found">Error: ${res.status} ${res.statusText}</p>`;
      return;
    }
    const card = await res.json();
    result.innerHTML = `
      <h2>${card.cardName} Found!</h2>
      <ul>
        <li><b>Mana Cost:</b> ${card.baseManaCost ?? '-'}</li>
        <li><b>Color Identity:</b> ${card.colorIdentity ?? '-'}</li>
        <li><b>Type:</b> ${card.cardType ?? '-'}</li>
        <li><b>Rarity:</b> ${card.rarity ?? '-'}</li>
        <li><b>Description Text:</b> ${card.descriptionText ?? '-'}</li>
       
      </ul>
    `;
  } catch (err) {
    result.innerHTML = `<p class="not-found">Network error: ${err}</p>`;
  }
}

button.addEventListener('click', lookup);
input.addEventListener('keydown', (e) => { if (e.key === 'Enter') lookup(); });