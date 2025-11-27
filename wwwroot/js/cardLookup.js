const input = document.getElementById('cardName')
const button = document.getElementById('searchBtn')
const resultsDiv = document.getElementById('result')

button.addEventListener("click", () => {
  const query = input.value.trim();
  if (!query) {
    resultsDiv.innerHTML = "<p>Please enter a card name.</p>";
    return;
  }

  searchCards(query);
});

async function searchCards(query) {
  try {
    // call your ASP.NET Core API
    const response = await fetch(`/api/cards/search?q=${encodeURIComponent(query)}`);

    if (!response.ok) {
      const text = await response.text();
      resultsDiv.innerHTML = `<p>Error: ${text}</p>`;
      return;
    }

    const cards = await response.json();

    if (cards.length === 0) {
      resultsDiv.innerHTML = "<p>No cards found.</p>";
      return;
    }

    // Render results
    resultsDiv.innerHTML = "";

    cards.forEach(card => {
      const div = document.createElement("div");
      div.style.border = "1px solid #ccc";
      div.style.margin = "8px 0";
      div.style.padding = "8px";

      div.innerHTML = `
        <h3>${card.name}</h3>
        <ul>
          <li><b>Mana Cost:</b> ${card.ManaCost ?? "-"}</li>
          <li><b>Color Identity:</b> ${card.colorIdentity ?? "-"}</li>
          <li><b>Type:</b> ${card.type ?? "-"}</li>
          <li><b>Power/Toughness:</b> ${card.power ?? "-"} / ${card.toughness ?? "-"}</li>
          <li><b>ID:</b> ${card.id}</li>
        </ul>
      `;

      resultsDiv.appendChild(div);
    });
  } catch (err) {
    console.error(err);
    resultsDiv.innerHTML = "<p>Unexpected error. Check console.</p>";
  }
}