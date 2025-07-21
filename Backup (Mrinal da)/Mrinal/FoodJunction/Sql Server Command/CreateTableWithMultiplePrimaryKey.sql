USE [FoodJunction]
GO

/****** Object:  Table [dbo].[T_BillSub]    Script Date: 31/03/2018 7:44:15 AM ******/
DROP TABLE [dbo].[T_BillSub]
GO

/****** Object:  Table [dbo].[T_BillSub]    Script Date: 31/03/2018 7:44:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T_BillSub](
	[BillId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[Qty] [int] NULL,
	[Amt] [decimal](18, 2) NULL,
	[Deliv] [float] NULL,
	[KOT] [float] NULL,
 CONSTRAINT [PK_T_BillSub] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC,
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


