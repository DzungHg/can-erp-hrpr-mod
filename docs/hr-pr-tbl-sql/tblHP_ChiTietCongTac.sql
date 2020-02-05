USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_ChiTietCongTac]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_ChiTietCongTac](
	[ChiTietCongTac_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[NhanVien_FK] [char](4),
	[NgayBienDong] [date],
	[QuyetDinhSo] [nvarchar] (15),
	[DonViCu] [nvarchar] (25),
	[ChucVuCu] [nvarchar] (25),
	[DonViHienNay]  [nvarchar] (25),
	[ChucVuHienNay] [nvarchar] (20),
 CONSTRAINT [pk_HP_ChiTietCongTac] PRIMARY KEY CLUSTERED 
(
	[ChiTietCongTac_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


