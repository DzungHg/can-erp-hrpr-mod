USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_TrinhDoChuyenMon]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_TrinhDoChuyenMon](
	[TrinhDoChuyenMon_ID] [char](2) NOT NULL,
	[TrinhDoChuyenMon_Name] [nvarchar](20) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [pk_HP_TrinhDoChuyenMon] PRIMARY KEY CLUSTERED 
(
	[TrinhDoChuyenMon_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


