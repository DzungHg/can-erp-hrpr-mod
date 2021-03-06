USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_ChiTietLuong]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_ChiTietLuong](
	[ChiTietLuong_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[NhanVien_FK] [char](4),
	[NgayHuongLuong] [date],
	[QuyetDinhSo] [nvarchar] (15),
	[NgayKy] [date],
	[CoQuanKy] [nvarchar] (20),
	[Ngach]  [nvarchar] (45),
	[Bac] [nvarchar] (35),
	[HeSoLuong] [float],
	[HeSoPhuCapChucVu] [float], 
	[HeSoPhuCapDocHai] [float],
	[DienGiai] [nvarchar] (45),
 CONSTRAINT [pk_HP_ChiTietLuong] PRIMARY KEY CLUSTERED 
(
	[ChiTietLuong_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


