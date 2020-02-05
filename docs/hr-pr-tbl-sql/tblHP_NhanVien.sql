USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_NhanVien]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_NhanVien](
	[NhanVien_ID] [char](4) NOT NULL,
	[HoTenLot] [nvarchar](30),
	[Ten] [nvarchar](70),
	[MaTheChamCong] [nvarchar](12),
	[PhaiNam] [bit],
	[HinhAnh] [image],
	[NgayThangNamSinh] [date],
	[NamSinh] [smallint],
	[NoiSinh_FK] [char] (5),
	[QueQuan_FK] [char] (5),
	[DanToc_FK] [char] (2),
	[TonGiao_FK] [char] (2),
	[QuocTich_FK] [char] (2),
	[SoCMND] [char] (12),
	[NgayCapCMND] [date],
	[NoiCapCMND] [nvarchar] (25),
	[HoKhau] [nvarchar] (50),
	[QuanHoKhau_FK]  [char] (3),
	[TinhTPHoKhau_FK] [char] (5),
	[ChoOHienNay] [nvarchar] (50),
	[QuanChoOHienNay_FK] [char] (3),
	[TinhTPChoOHienNay_FK] [char] (5),
	[SoDienThoai] [nvarchar] (25),
	[Email] [nvarchar] (50),
	[MaSoThueCaNhan] [varchar] (10),
	[TaiKhoanThanhToan] [varchar] (15),
	[HoTenATM] [nvarchar] (30),
	[MaKeToan] [varchar] (10),
	[GiaCanh] [smallint],
	[SoCon] [smallint],
	[LoaiHopDongLD] [smallint],
	[HopDongLaoDong] [nvarchar] (250),
	[Department_FK] [char] (5),
	[DonViTo_FK] [char] (9),
	[ChucVu_FK] [char] (3),
	[ThongTinLuuTru] [nvarchar] (255),
	[ThuViec] [bit],
	[DaNghiViec] [bit],
	[NgayNghiViec] [date],
	[TrinhDoHocVan_FK] [char] (2),
	[Ngach_FK] [char] (10),
	[Bac_FK] [char] (2),
	[HeSoLuong] [float],
	[LuongCoBan] [bigint],
	[HeSoPhuCapChucVu] [float],
	[HeSoPhuCapDocHai] [float],
	[HeSoDiemPhucTap] [float],
	[HeSoPhuCapThamNien] [float],
	[SoNguoiPhuThuoc] [tinyint],
	[SoBHXH] [varchar] (15),
	[NgayNhatTu] [datetime],
	
	
 CONSTRAINT [pk_HP_NhanVien] PRIMARY KEY CLUSTERED 
(
	[NhanVien_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


