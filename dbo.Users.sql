CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(20) NOT NULL, 
    [LastName] NCHAR(20) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)
