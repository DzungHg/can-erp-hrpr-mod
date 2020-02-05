USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblHP_ChiTietNgoaiNgu]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblHP_ChiTietNgoaiNgu](
	[ChiTietNgoaiNgu_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[NhanVien_FK] [char](4),
	[NgoaiNgu_FK] [char](2),
	[TrinhDo_FK]  [char](2),
	[VanBang]  [nvarchar](25),
	
 CONSTRAINT [pk_HP_ChiTietNgoaiNgu] PRIMARY KEY CLUSTERED 
(
	[ChiTietNgoaiNgu_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


