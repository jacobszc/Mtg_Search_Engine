using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoosterConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoostersTotalWeight = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceSetCodes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoosterConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoosterSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowDuplicates = table.Column<bool>(type: "bit", nullable: true),
                    BalanceColors = table.Column<bool>(type: "bit", nullable: true),
                    Foil = table.Column<bool>(type: "bit", nullable: false),
                    Fixed = table.Column<bool>(type: "bit", nullable: true),
                    TotalWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoosterSheet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Identifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbuId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomEtchedId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomFoilId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardsphereId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardsphereFoilId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardtraderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CsiId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    McmId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    McmMetaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiniaturemarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgArenaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgjsonFoilVersionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgjsonNonFoilVersionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgjsonV4Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgoFoilId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultiverseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScgId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallCardBackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallOracleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallIllustrationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerEtchedProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TntId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadershipSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brawl = table.Column<bool>(type: "bit", nullable: false),
                    commander = table.Column<bool>(type: "bit", nullable: false),
                    oatherbreaker = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadershipSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Legalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alchemy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commander = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explorer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Future = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gladiator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historicbrawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oathbreaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oldschool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pauper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paupercommander = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Penny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pioneer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Predh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Premodern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standardbrawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timeless = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vintage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardKingdom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomEtched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomFoil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardmarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tcgplayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerEtched = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseUrls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelatedCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reverseRelated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SealedProductContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SealedProductVariableConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductVariableConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourceProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    etched = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nonfoil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AncientGreek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arabic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChineseSimplified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChineseTraditional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    French = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    German = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hebrew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Italian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Japanese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Korean = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phyrexian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortugueseBrazil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Russian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sanskrit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spanish = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoosterPack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    BoosterConfigId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoosterPack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoosterPack_BoosterConfig_BoosterConfigId",
                        column: x => x.BoosterConfigId,
                        principalTable: "BoosterConfig",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foil = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SealedProductContentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProductCard_SealedProductContents_SealedProductContentsId",
                        column: x => x.SealedProductContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductDeck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SealedProductContentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductDeck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProductDeck_SealedProductContents_SealedProductContentsId",
                        column: x => x.SealedProductContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductOther",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SealedProductContentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductOther", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProductOther_SealedProductContents_SealedProductContentsId",
                        column: x => x.SealedProductContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductPack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SealedProductContentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductPack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProductPack_SealedProductContents_SealedProductContentsId",
                        column: x => x.SealedProductContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductSealed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SealedProductContentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductSealed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProductSealed_SealedProductContents_SealedProductContentsId",
                        column: x => x.SealedProductContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProductContentsSealedProductVariableConfig",
                columns: table => new
                {
                    ConfigsId = table.Column<int>(type: "int", nullable: false),
                    VariableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProductContentsSealedProductVariableConfig", x => new { x.ConfigsId, x.VariableId });
                    table.ForeignKey(
                        name: "FK_SealedProductContentsSealedProductVariableConfig_SealedProductContents_ConfigsId",
                        column: x => x.ConfigsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SealedProductContentsSealedProductVariableConfig_SealedProductVariableConfig_VariableId",
                        column: x => x.VariableId,
                        principalTable: "SealedProductVariableConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseSetSize = table.Column<int>(type: "int", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardsphereSetId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeV3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsForeignOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsFoilOnly = table.Column<bool>(type: "bit", nullable: false),
                    IsNonFoilOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsOnlineOnly = table.Column<bool>(type: "bit", nullable: false),
                    IsPaperOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsPartialPreview = table.Column<bool>(type: "bit", nullable: true),
                    KeyruneCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    McmId = table.Column<int>(type: "int", nullable: true),
                    McmIdExtras = table.Column<int>(type: "int", nullable: true),
                    McmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcgplayerGroupId = table.Column<int>(type: "int", nullable: true),
                    TokenSetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSetSize = table.Column<int>(type: "int", nullable: false),
                    TranslationsId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Set_Translations_TranslationsId",
                        column: x => x.TranslationsId,
                        principalTable: "Translations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsciiName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttractionLights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoosterTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManaValue = table.Column<double>(type: "float", nullable: false),
                    Defense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuelDeck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdhrecRank = table.Column<int>(type: "int", nullable: true),
                    EdhrecSaltiness = table.Column<double>(type: "float", nullable: true),
                    FaceFlavorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceManaValue = table.Column<double>(type: "float", nullable: true),
                    FaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finishes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlavorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasAlternativeDeckLimit = table.Column<bool>(type: "bit", nullable: true),
                    HasContentWarning = table.Column<bool>(type: "bit", nullable: true),
                    IdentifiersId = table.Column<int>(type: "int", nullable: false),
                    IsAlternative = table.Column<bool>(type: "bit", nullable: true),
                    IsFullArt = table.Column<bool>(type: "bit", nullable: true),
                    IsFunny = table.Column<bool>(type: "bit", nullable: true),
                    IsGameChanger = table.Column<bool>(type: "bit", nullable: true),
                    IsOnlineOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsOversized = table.Column<bool>(type: "bit", nullable: true),
                    IsPromo = table.Column<bool>(type: "bit", nullable: true),
                    IsRebalanced = table.Column<bool>(type: "bit", nullable: true),
                    IsReprint = table.Column<bool>(type: "bit", nullable: true),
                    IsReserved = table.Column<bool>(type: "bit", nullable: true),
                    IsStarter = table.Column<bool>(type: "bit", nullable: true),
                    IsStorySpotlight = table.Column<bool>(type: "bit", nullable: true),
                    IsTextless = table.Column<bool>(type: "bit", nullable: true),
                    IsTimeshifted = table.Column<bool>(type: "bit", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeadershipSkillsId = table.Column<int>(type: "int", nullable: true),
                    LegalitiesId = table.Column<int>(type: "int", nullable: false),
                    Life = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loyalty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPrintings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherFaceIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Printings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromoTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseUrlsId = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RebalancedPrintings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceProductsId = table.Column<int>(type: "int", nullable: true),
                    Subsets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supertypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toughness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Watermark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardSet_Identifiers_IdentifiersId",
                        column: x => x.IdentifiersId,
                        principalTable: "Identifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSet_LeadershipSkills_LeadershipSkillsId",
                        column: x => x.LeadershipSkillsId,
                        principalTable: "LeadershipSkills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardSet_Legalities_LegalitiesId",
                        column: x => x.LegalitiesId,
                        principalTable: "Legalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSet_PurchaseUrls_PurchaseUrlsId",
                        column: x => x.PurchaseUrlsId,
                        principalTable: "PurchaseUrls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSet_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardSet_SourceProducts_SourceProductsId",
                        column: x => x.SourceProductsId,
                        principalTable: "SourceProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsciiName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoosterTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EdhrecSaltiness = table.Column<double>(type: "float", nullable: true),
                    FaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceFlavorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finishes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlavorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFoil = table.Column<bool>(type: "bit", nullable: false),
                    HasNonFoil = table.Column<bool>(type: "bit", nullable: false),
                    IdentifiersId = table.Column<int>(type: "int", nullable: false),
                    IsFullArt = table.Column<bool>(type: "bit", nullable: true),
                    IsFunny = table.Column<bool>(type: "bit", nullable: true),
                    IsOnlineOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsOversized = table.Column<bool>(type: "bit", nullable: true),
                    IsPromo = table.Column<bool>(type: "bit", nullable: true),
                    IsReprint = table.Column<bool>(type: "bit", nullable: true),
                    IsTextless = table.Column<bool>(type: "bit", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loyalty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orientation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherFaceIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromoTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedCardsId = table.Column<int>(type: "int", nullable: true),
                    ReverseRelated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceProducts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subsets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supertypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toughness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Watermark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardToken_Identifiers_IdentifiersId",
                        column: x => x.IdentifiersId,
                        principalTable: "Identifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardToken_RelatedCards_RelatedCardsId",
                        column: x => x.RelatedCardsId,
                        principalTable: "RelatedCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardToken_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeckSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SealedProductUuids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeckSet_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SealedProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardCount = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentsId = table.Column<int>(type: "int", nullable: true),
                    IdentifiersId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductSize = table.Column<int>(type: "int", nullable: true),
                    PurchaseUrlsId = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SealedProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SealedProduct_Identifiers_IdentifiersId",
                        column: x => x.IdentifiersId,
                        principalTable: "Identifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SealedProduct_PurchaseUrls_PurchaseUrlsId",
                        column: x => x.PurchaseUrlsId,
                        principalTable: "PurchaseUrls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SealedProduct_SealedProductContents_ContentsId",
                        column: x => x.ContentsId,
                        principalTable: "SealedProductContents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SealedProduct_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForeignData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentifiersId = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForeignData_CardSet_CardSetId",
                        column: x => x.CardSetId,
                        principalTable: "CardSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForeignData_Identifiers_IdentifiersId",
                        column: x => x.IdentifiersId,
                        principalTable: "Identifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rulings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rulings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rulings_CardSet_CardSetId",
                        column: x => x.CardSetId,
                        principalTable: "CardSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardSetDeck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    IsFoil = table.Column<bool>(type: "bit", nullable: true),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeckSetId = table.Column<int>(type: "int", nullable: true),
                    DeckSetId1 = table.Column<int>(type: "int", nullable: true),
                    DeckSetId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSetDeck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardSetDeck_DeckSet_DeckSetId",
                        column: x => x.DeckSetId,
                        principalTable: "DeckSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardSetDeck_DeckSet_DeckSetId1",
                        column: x => x.DeckSetId1,
                        principalTable: "DeckSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardSetDeck_DeckSet_DeckSetId2",
                        column: x => x.DeckSetId2,
                        principalTable: "DeckSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoosterPack_BoosterConfigId",
                table: "BoosterPack",
                column: "BoosterConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_IdentifiersId",
                table: "CardSet",
                column: "IdentifiersId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_LeadershipSkillsId",
                table: "CardSet",
                column: "LeadershipSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_LegalitiesId",
                table: "CardSet",
                column: "LegalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_PurchaseUrlsId",
                table: "CardSet",
                column: "PurchaseUrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_SetId",
                table: "CardSet",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_SourceProductsId",
                table: "CardSet",
                column: "SourceProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSetDeck_DeckSetId",
                table: "CardSetDeck",
                column: "DeckSetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSetDeck_DeckSetId1",
                table: "CardSetDeck",
                column: "DeckSetId1");

            migrationBuilder.CreateIndex(
                name: "IX_CardSetDeck_DeckSetId2",
                table: "CardSetDeck",
                column: "DeckSetId2");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_IdentifiersId",
                table: "CardToken",
                column: "IdentifiersId");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_RelatedCardsId",
                table: "CardToken",
                column: "RelatedCardsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignData_CardSetId",
                table: "ForeignData",
                column: "CardSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignData_IdentifiersId",
                table: "ForeignData",
                column: "IdentifiersId");

            migrationBuilder.CreateIndex(
                name: "IX_Rulings_CardSetId",
                table: "Rulings",
                column: "CardSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_ContentsId",
                table: "SealedProduct",
                column: "ContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_IdentifiersId",
                table: "SealedProduct",
                column: "IdentifiersId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_PurchaseUrlsId",
                table: "SealedProduct",
                column: "PurchaseUrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductCard_SealedProductContentsId",
                table: "SealedProductCard",
                column: "SealedProductContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductContentsSealedProductVariableConfig_VariableId",
                table: "SealedProductContentsSealedProductVariableConfig",
                column: "VariableId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductDeck_SealedProductContentsId",
                table: "SealedProductDeck",
                column: "SealedProductContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductOther_SealedProductContentsId",
                table: "SealedProductOther",
                column: "SealedProductContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductPack_SealedProductContentsId",
                table: "SealedProductPack",
                column: "SealedProductContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProductSealed_SealedProductContentsId",
                table: "SealedProductSealed",
                column: "SealedProductContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_TranslationsId",
                table: "Set",
                column: "TranslationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoosterPack");

            migrationBuilder.DropTable(
                name: "BoosterSheet");

            migrationBuilder.DropTable(
                name: "CardSetDeck");

            migrationBuilder.DropTable(
                name: "CardToken");

            migrationBuilder.DropTable(
                name: "ForeignData");

            migrationBuilder.DropTable(
                name: "Rulings");

            migrationBuilder.DropTable(
                name: "SealedProduct");

            migrationBuilder.DropTable(
                name: "SealedProductCard");

            migrationBuilder.DropTable(
                name: "SealedProductContentsSealedProductVariableConfig");

            migrationBuilder.DropTable(
                name: "SealedProductDeck");

            migrationBuilder.DropTable(
                name: "SealedProductOther");

            migrationBuilder.DropTable(
                name: "SealedProductPack");

            migrationBuilder.DropTable(
                name: "SealedProductSealed");

            migrationBuilder.DropTable(
                name: "BoosterConfig");

            migrationBuilder.DropTable(
                name: "DeckSet");

            migrationBuilder.DropTable(
                name: "RelatedCards");

            migrationBuilder.DropTable(
                name: "CardSet");

            migrationBuilder.DropTable(
                name: "SealedProductVariableConfig");

            migrationBuilder.DropTable(
                name: "SealedProductContents");

            migrationBuilder.DropTable(
                name: "Identifiers");

            migrationBuilder.DropTable(
                name: "LeadershipSkills");

            migrationBuilder.DropTable(
                name: "Legalities");

            migrationBuilder.DropTable(
                name: "PurchaseUrls");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "SourceProducts");

            migrationBuilder.DropTable(
                name: "Translations");
        }
    }
}
