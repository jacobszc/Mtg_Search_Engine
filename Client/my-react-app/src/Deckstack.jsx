import { useState } from "react";

function DeckStack({ Deck, setDeck }) {
  const MAX_SLOTS = 100;
  const CARDS_PER_ROW = 20;

  const OFFSET_X = 10;
  const OFFSET_Y = 5;

  const CARD_W = 80;
  const CARD_H = 112;

  const totalRows = Math.ceil(MAX_SLOTS / CARDS_PER_ROW);

  const [hoveredCard, setHoveredCard] = useState(null);

  function removeOneCopy(urlToRemove) {
    setDeck(prev => {
      const index = prev.indexOf(urlToRemove);
      if (index === -1) return prev;

      return [...prev.slice(0, index), ...prev.slice(index + 1)];
    });
  }

  return (
    <>
      <div
        className="deck-stack"
        style={{
          position: "relative",
          width: CARD_W + OFFSET_X * (CARDS_PER_ROW - 1),
          height: totalRows * (CARD_H + OFFSET_Y),
        }}
      >
        {Array.from({ length: MAX_SLOTS }, (_, i) => {
          const card = Deck[i]; // card is a URL string

          const row = Math.floor(i / CARDS_PER_ROW);
          const col = i % CARDS_PER_ROW;

          return (
            <div
              key={i}
              style={{
                position: "absolute",
                left: col * OFFSET_X,
                top: row * (CARD_H + OFFSET_Y),
                width: CARD_W,
                height: CARD_H,
                pointerEvents: card ? "auto" : "none",
                zIndex: card ? col : -1,
              }}
            >
              {card && (
                <img
                  src={card}
                  alt=""
                  draggable={false}
                  onMouseEnter={() => setHoveredCard(card)}
                  onMouseLeave={() => setHoveredCard(null)}
                  onClick={() => removeOneCopy(card)} // click card to remove 1 copy
                  style={{
                    width: "100%",
                    height: "100%",
                    objectFit: "cover",
                    borderRadius: "12px",
                    boxShadow: "0 3px 10px rgba(0,0,0,0.25)",
                    cursor: "pointer",
                  }}
                />
              )}
            </div>
          );
        })}
      </div>

      {/* Hover preview */}
      {hoveredCard && (
        <div
          style={{
            position: "fixed",
            right: "50px",
            top: "50%",
            transform: "translateY(-50%)",
            width: "320px",
            zIndex: 9999,
            pointerEvents: "auto", // IMPORTANT: allow clicking
          }}
        >
          <img
            src={hoveredCard}
            alt=""
            onClick={() => removeOneCopy(hoveredCard)}
            style={{
              width: "100%",
              borderRadius: "16px",
              boxShadow: "0 8px 30px rgba(0,0,0,0.5)",
              cursor: "pointer",
            }}
          />
        </div>
      )}
    </>
  );
}

export default DeckStack;
