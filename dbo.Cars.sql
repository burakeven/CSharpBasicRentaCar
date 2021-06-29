CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] SMALLINT NOT NULL, 
    [DailyPrice] INT NULL, 
    [Description] VARCHAR(50) NOT NULL
)
