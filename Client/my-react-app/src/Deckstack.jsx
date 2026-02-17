function DeckStack({ Deck }) {
  const MAX_SLOTS = 100;
  const CARDS_PER_ROW = 20;

  const OFFSET_X = 10;   // how much each card overlaps horizontally
  const OFFSET_Y = 5;   // vertical spacing between rows

  const CARD_W = 80;
  const CARD_H = 112;

  const totalRows = Math.ceil(MAX_SLOTS / CARDS_PER_ROW);

  return (
    <div
      className="deck-stack"
      style={{
        position: "relative",
        width: CARD_W + OFFSET_X * (CARDS_PER_ROW - 1),
        height: totalRows * (CARD_H + OFFSET_Y),
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
              zIndex: col, // cards further right appear on top
            }}
          >
            {card && (
              <img
                src={card.img ?? card}
                alt=""
                draggable={false}
                style={{
                  width: "100%",
                  height: "100%",
                  objectFit: "cover",
                  borderRadius: "12px",
                  boxShadow: "0 3px 10px rgba(0,0,0,0.25)",
                }}
              />
            )}
          </div>
        );
      })}
    </div>
  );
}

export default DeckStack;
