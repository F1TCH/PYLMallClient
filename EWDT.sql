USE [EWDTdb]
GO
/****** Object:  Table [dbo].[Bidding]    Script Date: 12/1/2015 9:45:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bidding](
	[username] [varchar](50) NULL,
	[BiddingAmt] [varchar](50) NULL,
	[Date] [date] NULL,
	[Time] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FloorPlan]    Script Date: 12/1/2015 9:45:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FloorPlan](
	[Unit] [varchar](50) NULL,
	[UnitLevel] [int] NULL,
	[Name] [varchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[Condition] [varchar](50) NULL,
	[Imagefile] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 12/1/2015 9:45:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAccount](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[email] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 12/1/2015 9:45:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserProfile](
	[nric] [varchar](50) NULL,
	[Telno] [int] NULL,
	[Handphno] [int] NULL,
	[gender] [varchar](50) NULL,
	[DoB] [date] NULL,
	[SQ1] [varchar](50) NULL,
	[SQ2] [varchar](50) NULL,
	[SQAns1] [varchar](50) NULL,
	[SQAns2] [varchar](50) NULL,
	[username] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
