CREATE TABLE [dbo].[Tarif] (
    [Id]    INT            NOT NULL,
	[TypeID]  INT ,
    [Price] INT            NOT NULL,
    [Title] NVARCHAR (50)  NOT NULL,
    [Descr] NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

