/****** Object:  Table [dbo].[Customers]    Script Date: 6/8/2014 2:10:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT INTO Customers
SELECT 1, 'John Hammond', 'United States'
UNION ALL
SELECT 2, 'Mudassar Khan', 'India'
UNION ALL
SELECT 3, 'Suzanne Mathews', 'France'
UNION ALL
SELECT 4, 'Robert Schidner', 'Russia'

GO

USE [AjaxSamples]
GO

CREATE PROCEDURE [dbo].[Customers_CRUD]
	@Action VARCHAR(10)
	,@CustomerId INT = NULL
	,@Name VARCHAR(100) = NULL
	,@Country VARCHAR(100) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	--SELECT
    IF @Action = 'SELECT'
	BEGIN
		SELECT CustomerId, Name, Country 
		FROM Customers
	END

	--INSERT
    IF @Action = 'INSERT'
	BEGIN
		INSERT INTO Customers (Name, Country) 
		VALUES (@Name, @Country)
	END

	--UPDATE
    IF @Action = 'UPDATE'
	BEGIN
		UPDATE Customers 
		SET Name = @Name, Country = @Country 
		WHERE CustomerId = @CustomerId
	END

	--DELETE
    IF @Action = 'DELETE'
	BEGIN
		DELETE FROM Customers 
		WHERE CustomerId = @CustomerId
	END
END
GO

