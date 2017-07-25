USE [RanUser]
GO
/****** 物件:  Table [dbo].[CPSetting]    指令碼日期: 07/25/2017 22:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CPSetting](
	[ID] [int] NOT NULL,
	[MaxReborn] [int] NOT NULL CONSTRAINT [DF_CPSetting_MaxReborn]  DEFAULT ((30)),
	[RBPrimaryLvl] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBPrimaryLvl]  DEFAULT ((191)),
	[RBSecondaryLvl] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBSecondaryLvl]  DEFAULT ((201)),
	[RBAdvanceLvl] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBAdvanceLvl]  DEFAULT ((210)),
	[RBPrimary] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBPrimary]  DEFAULT ((30)),
	[RBSecondary] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBSecondary]  DEFAULT ((60)),
	[RBAdvance] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBAdvance]  DEFAULT ((100)),
	[RBPrimaryStat] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBPrimaryStat]  DEFAULT ((50)),
	[RBSecondaryStat] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBSecondaryStat]  DEFAULT ((100)),
	[RBAdvanceStat] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBAdvanceStat]  DEFAULT ((100)),
	[RBPrimaryGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBPrimaryGold]  DEFAULT ((0)),
	[RBSecondaryGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBSecondaryGold]  DEFAULT ((1000000)),
	[RBAdvanceGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_RBAdvanceGold]  DEFAULT ((10000000)),
	[RebornWait] [int] NOT NULL CONSTRAINT [DF_CPSetting_RebornWait]  DEFAULT ((1)),
	[AddStatGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_AddStatGold]  DEFAULT ((0)),
	[ChgSchoolGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_ChgSchoolGold]  DEFAULT ((10000000)),
	[ClearPKGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_ClearPKGold]  DEFAULT ((5000000)),
	[ChgNameGold] [int] NOT NULL CONSTRAINT [DF_CPSetting_ChgNameGold]  DEFAULT ((0)),
	[ChgNameWait] [int] NOT NULL CONSTRAINT [DF_CPSetting_ChgNameWait]  DEFAULT ((0)),
	[FormName] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_FormName]  DEFAULT ('Ran Online'),
	[EmailAddr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_EmailAddr]  DEFAULT ('example@email.com'),
	[EmailPwd] [varchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_EmailPwd]  DEFAULT ((123456)),
	[EmailPort] [int] NOT NULL CONSTRAINT [DF_CPSetting_EmailPort]  DEFAULT ((587)),
	[EmailHost] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_EmailHost]  DEFAULT ('mail.example.com'),
	[EmailSubject] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_EmailSubject]  DEFAULT ('Ran Online - Forgot Password'),
	[CharRemain] [int] NOT NULL CONSTRAINT [DF_CPSetting_CharRemain]  DEFAULT ((2)),
	[CharTestRemain] [int] NOT NULL CONSTRAINT [DF_CPSetting_CharTestRemain]  DEFAULT ((2)),
	[AdminPass] [varchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF_CPSetting_AdminPass]  DEFAULT ((1234)),
	[RankingDisplay] [int] NOT NULL CONSTRAINT [DF_CPSetting_RankingDisplay]  DEFAULT ((0)),
	[PasswordEncrypt] [int] NOT NULL CONSTRAINT [DF_CPSetting_PasswordEncrypt]  DEFAULT ((0)),
 CONSTRAINT [PK_CPSetting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF