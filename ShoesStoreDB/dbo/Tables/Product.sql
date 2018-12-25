CREATE TABLE [dbo].[Product] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Price]    DECIMAL (8, 2) NOT NULL,
    [IsActive] BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

