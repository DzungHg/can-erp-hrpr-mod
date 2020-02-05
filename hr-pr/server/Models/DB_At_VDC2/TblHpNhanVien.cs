using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_NhanVien", Schema = "dbo")]
  public partial class TblHpNhanVien
  {
    [Key]
    public string NhanVien_ID
    {
      get;
      set;
    }


    public ICollection<TblHpChiTietLuong> TblHpChiTietLuongs { get; set; }

    public ICollection<TblHpChiTietNgoaiNgu> TblHpChiTietNgoaiNgus { get; set; }

    public ICollection<TblHpChiTietGiaCanh> TblHpChiTietGiaCanhs { get; set; }

    public ICollection<TblHpChiTietCongTac> TblHpChiTietCongTacs { get; set; }

    public ICollection<TblHpChiTietChuyenMon> TblHpChiTietChuyenMons { get; set; }
    public string HoTenLot
    {
      get;
      set;
    }
    public string Ten
    {
      get;
      set;
    }
    public string MaTheChamCong
    {
      get;
      set;
    }
    public bool? PhaiNam
    {
      get;
      set;
    }
    public Byte[] HinhAnh
    {
      get;
      set;
    }
    public DateTime? NgayThangNamSinh
    {
      get;
      set;
    }
    public Int16? NamSinh
    {
      get;
      set;
    }
    public string NoiSinh_FK
    {
      get;
      set;
    }
    public TblHpTinhTp TblHpTinhTp { get; set; }
    public string QueQuan_FK
    {
      get;
      set;
    }
    public TblHpTinhTp TblHpTinhTp1 { get; set; }
    public string DanToc_FK
    {
      get;
      set;
    }
    public TblHpDanToc TblHpDanToc { get; set; }
    public string TonGiao_FK
    {
      get;
      set;
    }
    public TblHpTonGiao TblHpTonGiao { get; set; }
    public string QuocTich_FK
    {
      get;
      set;
    }
    public TblHpQuocTich TblHpQuocTich { get; set; }
    public string SoCMND
    {
      get;
      set;
    }
    public DateTime? NgayCapCMND
    {
      get;
      set;
    }
    public string NoiCapCMND
    {
      get;
      set;
    }
    public string HoKhau
    {
      get;
      set;
    }
    public string QuanHoKhau_FK
    {
      get;
      set;
    }
    public TblHpQuan TblHpQuan { get; set; }
    public string TinhTPHoKhau_FK
    {
      get;
      set;
    }
    public TblHpTinhTp TblHpTinhTp2 { get; set; }
    public string ChoOHienNay
    {
      get;
      set;
    }
    public string QuanChoOHienNay_FK
    {
      get;
      set;
    }
    public TblHpQuan TblHpQuan1 { get; set; }
    public string TinhTPChoOHienNay_FK
    {
      get;
      set;
    }
    public TblHpTinhTp TblHpTinhTp3 { get; set; }
    public string SoDienThoai
    {
      get;
      set;
    }
    public string Email
    {
      get;
      set;
    }
    public string MaSoThueCaNhan
    {
      get;
      set;
    }
    public string TaiKhoanThanhToan
    {
      get;
      set;
    }
    public string HoTenATM
    {
      get;
      set;
    }
    public string MaKeToan
    {
      get;
      set;
    }
    public Int16? GiaCanh
    {
      get;
      set;
    }
    public Int16? SoCon
    {
      get;
      set;
    }
    public Int16? LoaiHopDongLD
    {
      get;
      set;
    }
    public string HopDongLaoDong
    {
      get;
      set;
    }
    public string Department_FK
    {
      get;
      set;
    }
    public TblGnDepartment TblGnDepartment { get; set; }
    public string DonViTo_FK
    {
      get;
      set;
    }
    public TblHpDonViTo TblHpDonViTo { get; set; }
    public string ChucVu_FK
    {
      get;
      set;
    }
    public TblHpChucVu TblHpChucVu { get; set; }
    public string ThongTinLuuTru
    {
      get;
      set;
    }
    public bool? ThuViec
    {
      get;
      set;
    }
    public bool? DaNghiViec
    {
      get;
      set;
    }
    public DateTime? NgayNghiViec
    {
      get;
      set;
    }
    public string TrinhDoHocVan_FK
    {
      get;
      set;
    }
    public TblHpTrinhDoVanHoa TblHpTrinhDoVanHoa { get; set; }
    public string Ngach_FK
    {
      get;
      set;
    }
    public TblHpNgach TblHpNgach { get; set; }
    public string Bac_FK
    {
      get;
      set;
    }
    public TblHpBac TblHpBac { get; set; }
    public double? HeSoLuong
    {
      get;
      set;
    }
    public Int64? LuongCoBan
    {
      get;
      set;
    }
    public double? HeSoPhuCapChucVu
    {
      get;
      set;
    }
    public double? HeSoPhuCapDocHai
    {
      get;
      set;
    }
    public double? HeSoDiemPhucTap
    {
      get;
      set;
    }
    public double? HeSoPhuCapThamNien
    {
      get;
      set;
    }
    public Byte? SoNguoiPhuThuoc
    {
      get;
      set;
    }
    public string SoBHXH
    {
      get;
      set;
    }
    public DateTime? NgayNhatTu
    {
      get;
      set;
    }
  }
}
