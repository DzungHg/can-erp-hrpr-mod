USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_ChiTietGiaCanh]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_ChiTietGiaCanh](
	[ChiTietGiaCanh_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[NhanVien_FK] [char](4),
	[HoVaTen] [nvarchar](35),
	[NamSinh] [smallint],
	[PhaiNam] [bit],
	[QuanHe] [nvarchar] (8),
	[NgheNghiep]  [nvarchar] (30),
	[DaChet] [bit],
	
 CONSTRAINT [pk_HP_ChiTietGiaCanh] PRIMARY KEY CLUSTERED 
(
	[ChiTietGiaCanh_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


