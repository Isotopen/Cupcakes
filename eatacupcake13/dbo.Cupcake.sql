CREATE TABLE [dbo].[Cupcake] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [DateAdded]  DATETIME       NOT NULL,
    [SeasonType] NVARCHAR (20)  NOT NULL,
    [Seasonal]   BIT            NOT NULL,
    [Notes]      NVARCHAR (500) NOT NULL,
    CONSTRAINT [PK_dbo.Cupcake] PRIMARY KEY CLUSTERED ([Id] ASC)
);

