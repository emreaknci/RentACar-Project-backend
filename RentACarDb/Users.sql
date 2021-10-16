CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(255) NOT NULL, 
    [Password] NVARCHAR(255) NOT NULL
)
