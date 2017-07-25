USE [RanUser]
GO
/****** 物件:  Table [dbo].[CPTransaction]    指令碼日期: 07/25/2017 22:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CPTransaction](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Bank] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Amount] [int] NOT NULL CONSTRAINT [DF_CPTransaction_Amount]  DEFAULT ((0)),
	[Currency] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Channel] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Date] [datetime] NOT NULL CONSTRAINT [DF_CPTransaction_Date]  DEFAULT (getdate()),
	[Status] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Reason] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL CONSTRAINT [DF_CPTransaction_Reason]  DEFAULT (N'-'),
	[RefSEQNo] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL CONSTRAINT [DF_CPTransaction_RefSEQNo]  DEFAULT (N'-'),
 CONSTRAINT [PK_CPTransaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF