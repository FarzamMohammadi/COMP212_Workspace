USE master; 
GO 
 
--Delete the ddd database if it exists. 
IF EXISTS(SELECT * from sys.databases WHERE name='ddd') 
BEGIN 
    DROP DATABASE ddd; 
END 

CREATE DATABASE ddd;
GO

USE ddd;
GO

CREATE TABLE [dbo].[Fruits] (
    [FruitId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [Color]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Fruits] PRIMARY KEY CLUSTERED ([FruitId] ASC)
);
GO

INSERT INTO [dbo].[Fruits] ( [Name], [Color] ) VALUES('kiwi','red');
INSERT INTO [dbo].[Fruits] ( [Name], [Color] ) VALUES('grape','blau');
INSERT INTO [dbo].[Fruits] ( [Name], [Color] ) VALUES('dates','red');
INSERT INTO [dbo].[Fruits] ( [Name], [Color] ) VALUES('pear','blau');

GO

CREATE TABLE [dbo].[Planets] (
    [PlanetId] INT            IDENTITY (1, 1) NOT NULL,
    [Name2]    NVARCHAR (MAX) NULL,
    [Color2]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Planets] PRIMARY KEY CLUSTERED ([PlanetId] ASC)
);
GO

INSERT INTO [dbo].[Planets] ( [Name2], [Color2] ) VALUES('Earth','red');
INSERT INTO [dbo].[Planets] ( [Name2], [Color2] ) VALUES('Jupiter','blau');
