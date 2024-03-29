USE [EWDTdb]
GO
/****** Object:  Table [dbo].[Bidding]    Script Date: 12/27/2014 5:00:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bidding](
	[BiddingAmt] [decimal](18, 0) NOT NULL,
	[Date] [date] NULL,
	[Time] [time](7) NULL,
 CONSTRAINT [PK_Bidding] PRIMARY KEY CLUSTERED 
(
	[BiddingAmt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FloorPlan]    Script Date: 12/27/2014 5:00:32 PM ******/
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
/****** Object:  Table [dbo].[UserAccount]    Script Date: 12/27/2014 5:00:32 PM ******/
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
/****** Object:  Table [dbo].[UserProfile]    Script Date: 12/27/2014 5:00:32 PM ******/
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
ALTER TABLE [dbo].[Bidding]  WITH CHECK ADD  CONSTRAINT [FK_Bidding_Bidding] FOREIGN KEY([BiddingAmt])
REFERENCES [dbo].[Bidding] ([BiddingAmt])
GO
ALTER TABLE [dbo].[Bidding] CHECK CONSTRAINT [FK_Bidding_Bidding]
GO
