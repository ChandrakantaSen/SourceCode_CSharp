USE [FoodJunction]
GO

/****** Object:  Table [dbo].[T_ItemMaster]    Script Date: 20/03/2018 8:32:53 AM ******/
DROP TABLE [dbo].[T_ItemMaster]
GO

/****** Object:  Table [dbo].[T_ItemMaster]    Script Date: 20/03/2018 8:32:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T_ItemMaster](
	[ItmId] [int] NOT NULL Identity(1,1) Primary Key,
	[ItmCode] [nvarchar](10) NULL,
	[ItmNam] [nvarchar](50) NULL,
	[ItmPrice] [float] NULL,
	[ItmShotNam] [nvarchar](10) NULL,
	[ItemGrp] int NULL,
	[ItemImg] [image] NULL,
	[TaxId] int Null

) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


