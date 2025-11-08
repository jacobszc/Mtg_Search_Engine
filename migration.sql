IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [BoosterConfig] (
    [Id] int NOT NULL IDENTITY,
    [BoostersTotalWeight] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [SourceSetCodes] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_BoosterConfig] PRIMARY KEY ([Id])
);

CREATE TABLE [BoosterSheet] (
    [Id] int NOT NULL IDENTITY,
    [AllowDuplicates] bit NULL,
    [BalanceColors] bit NULL,
    [Foil] bit NOT NULL,
    [Fixed] bit NULL,
    [TotalWeight] int NOT NULL,
    CONSTRAINT [PK_BoosterSheet] PRIMARY KEY ([Id])
);

CREATE TABLE [Identifiers] (
    [Id] int NOT NULL IDENTITY,
    [AbuId] nvarchar(max) NULL,
    [CardKingdomEtchedId] nvarchar(max) NULL,
    [CardKingdomFoilId] nvarchar(max) NULL,
    [CardKingdomId] nvarchar(max) NULL,
    [CardsphereId] nvarchar(max) NULL,
    [CardsphereFoilId] nvarchar(max) NULL,
    [CardtraderId] nvarchar(max) NULL,
    [CsiId] nvarchar(max) NULL,
    [McmId] nvarchar(max) NULL,
    [McmMetaId] nvarchar(max) NULL,
    [MiniaturemarketId] nvarchar(max) NULL,
    [MtgArenaId] nvarchar(max) NULL,
    [MtgjsonFoilVersionId] nvarchar(max) NULL,
    [MtgjsonNonFoilVersionId] nvarchar(max) NULL,
    [MtgjsonV4Id] nvarchar(max) NULL,
    [MtgoFoilId] nvarchar(max) NULL,
    [MtgoId] nvarchar(max) NULL,
    [MultiverseId] nvarchar(max) NULL,
    [ScgId] nvarchar(max) NULL,
    [ScryfallId] nvarchar(max) NULL,
    [ScryfallCardBackId] nvarchar(max) NULL,
    [ScryfallOracleId] nvarchar(max) NULL,
    [ScryfallIllustrationId] nvarchar(max) NULL,
    [TcgplayerProductId] nvarchar(max) NULL,
    [TcgplayerEtchedProductId] nvarchar(max) NULL,
    [TntId] nvarchar(max) NULL,
    CONSTRAINT [PK_Identifiers] PRIMARY KEY ([Id])
);

CREATE TABLE [LeadershipSkills] (
    [Id] int NOT NULL IDENTITY,
    [brawl] bit NOT NULL,
    [commander] bit NOT NULL,
    [oatherbreaker] bit NOT NULL,
    CONSTRAINT [PK_LeadershipSkills] PRIMARY KEY ([Id])
);

CREATE TABLE [Legalities] (
    [Id] int NOT NULL IDENTITY,
    [Alchemy] nvarchar(max) NULL,
    [Brawl] nvarchar(max) NULL,
    [Commander] nvarchar(max) NULL,
    [Duel] nvarchar(max) NULL,
    [Explorer] nvarchar(max) NULL,
    [Future] nvarchar(max) NULL,
    [Gladiator] nvarchar(max) NULL,
    [Historic] nvarchar(max) NULL,
    [Historicbrawl] nvarchar(max) NULL,
    [Legacy] nvarchar(max) NULL,
    [Modern] nvarchar(max) NULL,
    [Oathbreaker] nvarchar(max) NULL,
    [Oldschool] nvarchar(max) NULL,
    [Pauper] nvarchar(max) NULL,
    [Paupercommander] nvarchar(max) NULL,
    [Penny] nvarchar(max) NULL,
    [Pioneer] nvarchar(max) NULL,
    [Predh] nvarchar(max) NULL,
    [Premodern] nvarchar(max) NULL,
    [Standard] nvarchar(max) NULL,
    [Standardbrawl] nvarchar(max) NULL,
    [Timeless] nvarchar(max) NULL,
    [Vintage] nvarchar(max) NULL,
    CONSTRAINT [PK_Legalities] PRIMARY KEY ([Id])
);

CREATE TABLE [PurchaseUrls] (
    [Id] int NOT NULL IDENTITY,
    [CardKingdom] nvarchar(max) NULL,
    [CardKingdomEtched] nvarchar(max) NULL,
    [CardKingdomFoil] nvarchar(max) NULL,
    [Cardmarket] nvarchar(max) NULL,
    [Tcgplayer] nvarchar(max) NULL,
    [TcgplayerEtched] nvarchar(max) NULL,
    CONSTRAINT [PK_PurchaseUrls] PRIMARY KEY ([Id])
);

CREATE TABLE [RelatedCards] (
    [Id] int NOT NULL IDENTITY,
    [reverseRelated] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_RelatedCards] PRIMARY KEY ([Id])
);

CREATE TABLE [SealedProductContents] (
    [Id] int NOT NULL IDENTITY,
    CONSTRAINT [PK_SealedProductContents] PRIMARY KEY ([Id])
);

CREATE TABLE [SealedProductVariableConfig] (
    [Id] int NOT NULL IDENTITY,
    CONSTRAINT [PK_SealedProductVariableConfig] PRIMARY KEY ([Id])
);

CREATE TABLE [SourceProducts] (
    [Id] int NOT NULL IDENTITY,
    [etched] nvarchar(max) NOT NULL,
    [foil] nvarchar(max) NOT NULL,
    [nonfoil] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_SourceProducts] PRIMARY KEY ([Id])
);

CREATE TABLE [Translations] (
    [Id] int NOT NULL IDENTITY,
    [AncientGreek] nvarchar(max) NULL,
    [Arabic] nvarchar(max) NULL,
    [ChineseSimplified] nvarchar(max) NULL,
    [ChineseTraditional] nvarchar(max) NULL,
    [French] nvarchar(max) NULL,
    [German] nvarchar(max) NULL,
    [Hebrew] nvarchar(max) NULL,
    [Italian] nvarchar(max) NULL,
    [Japanese] nvarchar(max) NULL,
    [Korean] nvarchar(max) NULL,
    [Latin] nvarchar(max) NULL,
    [Phyrexian] nvarchar(max) NULL,
    [PortugueseBrazil] nvarchar(max) NULL,
    [Russian] nvarchar(max) NULL,
    [Sanskrit] nvarchar(max) NULL,
    [Spanish] nvarchar(max) NULL,
    CONSTRAINT [PK_Translations] PRIMARY KEY ([Id])
);

CREATE TABLE [BoosterPack] (
    [Id] int NOT NULL IDENTITY,
    [Weight] int NOT NULL,
    [BoosterConfigId] int NULL,
    CONSTRAINT [PK_BoosterPack] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BoosterPack_BoosterConfig_BoosterConfigId] FOREIGN KEY ([BoosterConfigId]) REFERENCES [BoosterConfig] ([Id])
);

CREATE TABLE [SealedProductCard] (
    [Id] int NOT NULL IDENTITY,
    [Foil] bit NULL,
    [Name] nvarchar(max) NOT NULL,
    [Number] nvarchar(max) NOT NULL,
    [Set] nvarchar(max) NOT NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [SealedProductContentsId] int NULL,
    CONSTRAINT [PK_SealedProductCard] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProductCard_SealedProductContents_SealedProductContentsId] FOREIGN KEY ([SealedProductContentsId]) REFERENCES [SealedProductContents] ([Id])
);

CREATE TABLE [SealedProductDeck] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Set] nvarchar(max) NOT NULL,
    [SealedProductContentsId] int NULL,
    CONSTRAINT [PK_SealedProductDeck] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProductDeck_SealedProductContents_SealedProductContentsId] FOREIGN KEY ([SealedProductContentsId]) REFERENCES [SealedProductContents] ([Id])
);

CREATE TABLE [SealedProductOther] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [SealedProductContentsId] int NULL,
    CONSTRAINT [PK_SealedProductOther] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProductOther_SealedProductContents_SealedProductContentsId] FOREIGN KEY ([SealedProductContentsId]) REFERENCES [SealedProductContents] ([Id])
);

CREATE TABLE [SealedProductPack] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(max) NOT NULL,
    [Set] nvarchar(max) NOT NULL,
    [SealedProductContentsId] int NULL,
    CONSTRAINT [PK_SealedProductPack] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProductPack_SealedProductContents_SealedProductContentsId] FOREIGN KEY ([SealedProductContentsId]) REFERENCES [SealedProductContents] ([Id])
);

CREATE TABLE [SealedProductSealed] (
    [Id] int NOT NULL IDENTITY,
    [Count] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Set] nvarchar(max) NOT NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [SealedProductContentsId] int NULL,
    CONSTRAINT [PK_SealedProductSealed] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProductSealed_SealedProductContents_SealedProductContentsId] FOREIGN KEY ([SealedProductContentsId]) REFERENCES [SealedProductContents] ([Id])
);

CREATE TABLE [SealedProductContentsSealedProductVariableConfig] (
    [ConfigsId] int NOT NULL,
    [VariableId] int NOT NULL,
    CONSTRAINT [PK_SealedProductContentsSealedProductVariableConfig] PRIMARY KEY ([ConfigsId], [VariableId]),
    CONSTRAINT [FK_SealedProductContentsSealedProductVariableConfig_SealedProductContents_ConfigsId] FOREIGN KEY ([ConfigsId]) REFERENCES [SealedProductContents] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SealedProductContentsSealedProductVariableConfig_SealedProductVariableConfig_VariableId] FOREIGN KEY ([VariableId]) REFERENCES [SealedProductVariableConfig] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [Set] (
    [Id] int NOT NULL IDENTITY,
    [BaseSetSize] int NOT NULL,
    [Block] nvarchar(max) NULL,
    [CardsphereSetId] int NULL,
    [Code] nvarchar(max) NOT NULL,
    [CodeV3] nvarchar(max) NULL,
    [IsForeignOnly] bit NULL,
    [IsFoilOnly] bit NOT NULL,
    [IsNonFoilOnly] bit NULL,
    [IsOnlineOnly] bit NOT NULL,
    [IsPaperOnly] bit NULL,
    [IsPartialPreview] bit NULL,
    [KeyruneCode] nvarchar(max) NOT NULL,
    [Languages] nvarchar(max) NULL,
    [McmId] int NULL,
    [McmIdExtras] int NULL,
    [McmName] nvarchar(max) NULL,
    [MtgoCode] nvarchar(max) NULL,
    [Name] nvarchar(max) NOT NULL,
    [ParentCode] nvarchar(max) NULL,
    [ReleaseDate] nvarchar(max) NOT NULL,
    [TcgplayerGroupId] int NULL,
    [TokenSetCode] nvarchar(max) NULL,
    [TotalSetSize] int NOT NULL,
    [TranslationsId] int NOT NULL,
    [Type] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Set] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Set_Translations_TranslationsId] FOREIGN KEY ([TranslationsId]) REFERENCES [Translations] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [CardSet] (
    [Id] int NOT NULL IDENTITY,
    [Artist] nvarchar(max) NULL,
    [ArtistIds] nvarchar(max) NULL,
    [AsciiName] nvarchar(max) NULL,
    [AttractionLights] nvarchar(max) NULL,
    [Availability] nvarchar(max) NOT NULL,
    [BoosterTypes] nvarchar(max) NULL,
    [BorderColor] nvarchar(max) NOT NULL,
    [CardParts] nvarchar(max) NULL,
    [ColorIdentity] nvarchar(max) NOT NULL,
    [ColorIndicator] nvarchar(max) NULL,
    [Colors] nvarchar(max) NOT NULL,
    [ManaValue] float NOT NULL,
    [Defense] nvarchar(max) NULL,
    [DuelDeck] nvarchar(max) NULL,
    [EdhrecRank] int NULL,
    [EdhrecSaltiness] float NULL,
    [FaceFlavorName] nvarchar(max) NULL,
    [FaceManaValue] float NULL,
    [FaceName] nvarchar(max) NULL,
    [Finishes] nvarchar(max) NOT NULL,
    [FlavorName] nvarchar(max) NULL,
    [FlavorText] nvarchar(max) NULL,
    [FrameEffects] nvarchar(max) NULL,
    [FrameVersion] nvarchar(max) NOT NULL,
    [Hand] nvarchar(max) NULL,
    [HasAlternativeDeckLimit] bit NULL,
    [HasContentWarning] bit NULL,
    [IdentifiersId] int NOT NULL,
    [IsAlternative] bit NULL,
    [IsFullArt] bit NULL,
    [IsFunny] bit NULL,
    [IsGameChanger] bit NULL,
    [IsOnlineOnly] bit NULL,
    [IsOversized] bit NULL,
    [IsPromo] bit NULL,
    [IsRebalanced] bit NULL,
    [IsReprint] bit NULL,
    [IsReserved] bit NULL,
    [IsStarter] bit NULL,
    [IsStorySpotlight] bit NULL,
    [IsTextless] bit NULL,
    [IsTimeshifted] bit NULL,
    [Keywords] nvarchar(max) NULL,
    [Language] nvarchar(max) NOT NULL,
    [Layout] nvarchar(max) NOT NULL,
    [LeadershipSkillsId] int NULL,
    [LegalitiesId] int NOT NULL,
    [Life] nvarchar(max) NULL,
    [Loyalty] nvarchar(max) NULL,
    [ManaCost] nvarchar(max) NULL,
    [Name] nvarchar(max) NOT NULL,
    [Number] nvarchar(max) NOT NULL,
    [OriginalPrintings] nvarchar(max) NULL,
    [OriginalReleaseDate] nvarchar(max) NULL,
    [OriginalText] nvarchar(max) NULL,
    [OriginalType] nvarchar(max) NULL,
    [OtherFaceIds] nvarchar(max) NULL,
    [Power] nvarchar(max) NULL,
    [Printings] nvarchar(max) NULL,
    [PromoTypes] nvarchar(max) NULL,
    [PurchaseUrlsId] int NOT NULL,
    [Rarity] nvarchar(max) NOT NULL,
    [RebalancedPrintings] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [SetCode] nvarchar(max) NOT NULL,
    [Side] nvarchar(max) NULL,
    [Signature] nvarchar(max) NULL,
    [SourceProductsId] int NULL,
    [Subsets] nvarchar(max) NULL,
    [Subtypes] nvarchar(max) NOT NULL,
    [Supertypes] nvarchar(max) NOT NULL,
    [Text] nvarchar(max) NULL,
    [Toughness] nvarchar(max) NULL,
    [Type] nvarchar(max) NOT NULL,
    [Types] nvarchar(max) NOT NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [Variations] nvarchar(max) NULL,
    [Watermark] nvarchar(max) NULL,
    [SetId] int NULL,
    CONSTRAINT [PK_CardSet] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CardSet_Identifiers_IdentifiersId] FOREIGN KEY ([IdentifiersId]) REFERENCES [Identifiers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CardSet_LeadershipSkills_LeadershipSkillsId] FOREIGN KEY ([LeadershipSkillsId]) REFERENCES [LeadershipSkills] ([Id]),
    CONSTRAINT [FK_CardSet_Legalities_LegalitiesId] FOREIGN KEY ([LegalitiesId]) REFERENCES [Legalities] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CardSet_PurchaseUrls_PurchaseUrlsId] FOREIGN KEY ([PurchaseUrlsId]) REFERENCES [PurchaseUrls] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CardSet_Set_SetId] FOREIGN KEY ([SetId]) REFERENCES [Set] ([Id]),
    CONSTRAINT [FK_CardSet_SourceProducts_SourceProductsId] FOREIGN KEY ([SourceProductsId]) REFERENCES [SourceProducts] ([Id])
);

CREATE TABLE [CardToken] (
    [Id] int NOT NULL IDENTITY,
    [Artist] nvarchar(max) NULL,
    [ArtistIds] nvarchar(max) NULL,
    [AsciiName] nvarchar(max) NULL,
    [Availability] nvarchar(max) NOT NULL,
    [BoosterTypes] nvarchar(max) NULL,
    [BorderColor] nvarchar(max) NOT NULL,
    [CardParts] nvarchar(max) NULL,
    [ColorIdentity] nvarchar(max) NOT NULL,
    [ColorIndicator] nvarchar(max) NULL,
    [Colors] nvarchar(max) NOT NULL,
    [EdhrecSaltiness] float NULL,
    [FaceName] nvarchar(max) NULL,
    [FaceFlavorName] nvarchar(max) NULL,
    [Finishes] nvarchar(max) NOT NULL,
    [FlavorName] nvarchar(max) NULL,
    [FlavorText] nvarchar(max) NULL,
    [FrameEffects] nvarchar(max) NULL,
    [FrameVersion] nvarchar(max) NOT NULL,
    [HasFoil] bit NOT NULL,
    [HasNonFoil] bit NOT NULL,
    [IdentifiersId] int NOT NULL,
    [IsFullArt] bit NULL,
    [IsFunny] bit NULL,
    [IsOnlineOnly] bit NULL,
    [IsOversized] bit NULL,
    [IsPromo] bit NULL,
    [IsReprint] bit NULL,
    [IsTextless] bit NULL,
    [Keywords] nvarchar(max) NULL,
    [Language] nvarchar(max) NOT NULL,
    [Layout] nvarchar(max) NOT NULL,
    [Loyalty] nvarchar(max) NULL,
    [ManaCost] nvarchar(max) NULL,
    [Name] nvarchar(max) NOT NULL,
    [Number] nvarchar(max) NOT NULL,
    [Orientation] nvarchar(max) NULL,
    [OriginalText] nvarchar(max) NULL,
    [OriginalType] nvarchar(max) NULL,
    [OtherFaceIds] nvarchar(max) NULL,
    [Power] nvarchar(max) NULL,
    [PromoTypes] nvarchar(max) NULL,
    [RelatedCardsId] int NULL,
    [ReverseRelated] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [SetCode] nvarchar(max) NOT NULL,
    [Side] nvarchar(max) NULL,
    [Signature] nvarchar(max) NULL,
    [SourceProducts] nvarchar(max) NULL,
    [Subsets] nvarchar(max) NULL,
    [Subtypes] nvarchar(max) NOT NULL,
    [Supertypes] nvarchar(max) NOT NULL,
    [Text] nvarchar(max) NULL,
    [Toughness] nvarchar(max) NULL,
    [Type] nvarchar(max) NOT NULL,
    [Types] nvarchar(max) NOT NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [Watermark] nvarchar(max) NULL,
    [SetId] int NULL,
    CONSTRAINT [PK_CardToken] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CardToken_Identifiers_IdentifiersId] FOREIGN KEY ([IdentifiersId]) REFERENCES [Identifiers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CardToken_RelatedCards_RelatedCardsId] FOREIGN KEY ([RelatedCardsId]) REFERENCES [RelatedCards] ([Id]),
    CONSTRAINT [FK_CardToken_Set_SetId] FOREIGN KEY ([SetId]) REFERENCES [Set] ([Id])
);

CREATE TABLE [DeckSet] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [ReleaseDate] nvarchar(max) NULL,
    [SealedProductUuids] nvarchar(max) NULL,
    [Type] nvarchar(max) NOT NULL,
    [SetId] int NULL,
    CONSTRAINT [PK_DeckSet] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DeckSet_Set_SetId] FOREIGN KEY ([SetId]) REFERENCES [Set] ([Id])
);

CREATE TABLE [SealedProduct] (
    [Id] int NOT NULL IDENTITY,
    [CardCount] int NULL,
    [Category] nvarchar(max) NULL,
    [ContentsId] int NULL,
    [IdentifiersId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [ProductSize] int NULL,
    [PurchaseUrlsId] int NOT NULL,
    [ReleaseDate] nvarchar(max) NULL,
    [Subtype] nvarchar(max) NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [SetId] int NULL,
    CONSTRAINT [PK_SealedProduct] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SealedProduct_Identifiers_IdentifiersId] FOREIGN KEY ([IdentifiersId]) REFERENCES [Identifiers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SealedProduct_PurchaseUrls_PurchaseUrlsId] FOREIGN KEY ([PurchaseUrlsId]) REFERENCES [PurchaseUrls] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SealedProduct_SealedProductContents_ContentsId] FOREIGN KEY ([ContentsId]) REFERENCES [SealedProductContents] ([Id]),
    CONSTRAINT [FK_SealedProduct_Set_SetId] FOREIGN KEY ([SetId]) REFERENCES [Set] ([Id])
);

CREATE TABLE [ForeignData] (
    [Id] int NOT NULL IDENTITY,
    [FaceName] nvarchar(max) NULL,
    [FlavorText] nvarchar(max) NULL,
    [IdentifiersId] int NOT NULL,
    [Language] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Text] nvarchar(max) NULL,
    [Type] nvarchar(max) NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [CardSetId] int NULL,
    CONSTRAINT [PK_ForeignData] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ForeignData_CardSet_CardSetId] FOREIGN KEY ([CardSetId]) REFERENCES [CardSet] ([Id]),
    CONSTRAINT [FK_ForeignData_Identifiers_IdentifiersId] FOREIGN KEY ([IdentifiersId]) REFERENCES [Identifiers] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [Rulings] (
    [Id] int NOT NULL IDENTITY,
    [date] nvarchar(max) NOT NULL,
    [text] nvarchar(max) NOT NULL,
    [CardSetId] int NULL,
    CONSTRAINT [PK_Rulings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Rulings_CardSet_CardSetId] FOREIGN KEY ([CardSetId]) REFERENCES [CardSet] ([Id])
);

CREATE TABLE [CardSetDeck] (
    [Id] int NOT NULL IDENTITY,
    [Count] int NOT NULL,
    [IsFoil] bit NULL,
    [Uuid] nvarchar(max) NOT NULL,
    [DeckSetId] int NULL,
    [DeckSetId1] int NULL,
    [DeckSetId2] int NULL,
    CONSTRAINT [PK_CardSetDeck] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CardSetDeck_DeckSet_DeckSetId] FOREIGN KEY ([DeckSetId]) REFERENCES [DeckSet] ([Id]),
    CONSTRAINT [FK_CardSetDeck_DeckSet_DeckSetId1] FOREIGN KEY ([DeckSetId1]) REFERENCES [DeckSet] ([Id]),
    CONSTRAINT [FK_CardSetDeck_DeckSet_DeckSetId2] FOREIGN KEY ([DeckSetId2]) REFERENCES [DeckSet] ([Id])
);

CREATE INDEX [IX_BoosterPack_BoosterConfigId] ON [BoosterPack] ([BoosterConfigId]);

CREATE INDEX [IX_CardSet_IdentifiersId] ON [CardSet] ([IdentifiersId]);

CREATE INDEX [IX_CardSet_LeadershipSkillsId] ON [CardSet] ([LeadershipSkillsId]);

CREATE INDEX [IX_CardSet_LegalitiesId] ON [CardSet] ([LegalitiesId]);

CREATE INDEX [IX_CardSet_PurchaseUrlsId] ON [CardSet] ([PurchaseUrlsId]);

CREATE INDEX [IX_CardSet_SetId] ON [CardSet] ([SetId]);

CREATE INDEX [IX_CardSet_SourceProductsId] ON [CardSet] ([SourceProductsId]);

CREATE INDEX [IX_CardSetDeck_DeckSetId] ON [CardSetDeck] ([DeckSetId]);

CREATE INDEX [IX_CardSetDeck_DeckSetId1] ON [CardSetDeck] ([DeckSetId1]);

CREATE INDEX [IX_CardSetDeck_DeckSetId2] ON [CardSetDeck] ([DeckSetId2]);

CREATE INDEX [IX_CardToken_IdentifiersId] ON [CardToken] ([IdentifiersId]);

CREATE INDEX [IX_CardToken_RelatedCardsId] ON [CardToken] ([RelatedCardsId]);

CREATE INDEX [IX_CardToken_SetId] ON [CardToken] ([SetId]);

CREATE INDEX [IX_DeckSet_SetId] ON [DeckSet] ([SetId]);

CREATE INDEX [IX_ForeignData_CardSetId] ON [ForeignData] ([CardSetId]);

CREATE INDEX [IX_ForeignData_IdentifiersId] ON [ForeignData] ([IdentifiersId]);

CREATE INDEX [IX_Rulings_CardSetId] ON [Rulings] ([CardSetId]);

CREATE INDEX [IX_SealedProduct_ContentsId] ON [SealedProduct] ([ContentsId]);

CREATE INDEX [IX_SealedProduct_IdentifiersId] ON [SealedProduct] ([IdentifiersId]);

CREATE INDEX [IX_SealedProduct_PurchaseUrlsId] ON [SealedProduct] ([PurchaseUrlsId]);

CREATE INDEX [IX_SealedProduct_SetId] ON [SealedProduct] ([SetId]);

CREATE INDEX [IX_SealedProductCard_SealedProductContentsId] ON [SealedProductCard] ([SealedProductContentsId]);

CREATE INDEX [IX_SealedProductContentsSealedProductVariableConfig_VariableId] ON [SealedProductContentsSealedProductVariableConfig] ([VariableId]);

CREATE INDEX [IX_SealedProductDeck_SealedProductContentsId] ON [SealedProductDeck] ([SealedProductContentsId]);

CREATE INDEX [IX_SealedProductOther_SealedProductContentsId] ON [SealedProductOther] ([SealedProductContentsId]);

CREATE INDEX [IX_SealedProductPack_SealedProductContentsId] ON [SealedProductPack] ([SealedProductContentsId]);

CREATE INDEX [IX_SealedProductSealed_SealedProductContentsId] ON [SealedProductSealed] ([SealedProductContentsId]);

CREATE INDEX [IX_Set_TranslationsId] ON [Set] ([TranslationsId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251108013021_InitialCreate', N'9.0.10');

COMMIT;
GO

