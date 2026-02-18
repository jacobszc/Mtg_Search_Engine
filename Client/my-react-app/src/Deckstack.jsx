import { useState } from "react";

function DeckStack({ Deck }) {
  const MAX_SLOTS = 100;
  const CARDS_PER_ROW = 20;

  const OFFSET_X = 10; // how much each card overlaps horizontally
  const OFFSET_Y = 5;  // vertical spacing between rows

  const CARD_W = 80;
  const CARD_H = 112;

  const totalRows = Math.ceil(MAX_SLOTS / CARDS_PER_ROW);

  const [hoveredCard, setHoveredCard] = useState(null);

  return (
    <>
      <div
        className="deck-stack"
        style={{
          position: "relative",
          width: CARD_W + OFFSET_X * (CARDS_PER_ROW - 1), // total width of deck area
          height: totalRows * (CARD_H + OFFSET_Y),        // total height of deck area
        }}
      >
        {Array.from({ length: MAX_SLOTS }, (_, i) => {
          const card = Deck[i];

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
                zIndex: card ? col : -1, // cards further right appear on top
              }}
            >
              {card && (
                <img
                  src={card.img ?? card}
                  alt=""
                  draggable={false}
                  onMouseEnter={() => setHoveredCard(card)}
                  onMouseLeave={() => setHoveredCard(null)}
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

     
      {hoveredCard && (
        <div
          style={{
            position: "fixed",
            right: "50px",
            top: "50%",
            transform: "translateY(-50%)",
            width: "320px",
            zIndex: 9999,
            pointerEvents: "none", // prevents preview from interrupting hover
          }}
        >
          <img
            src={hoveredCard.img ?? hoveredCard}
            alt=""
            style={{
              width: "100%",
              borderRadius: "16px",
              boxShadow: "0 8px 30px rgba(0,0,0,0.5)",
            }}
          />
        </div>
      )}
    </>
  );
}

export default DeckStack;
