using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("vwHR_LyLichNV", Schema = "dbo")]
  public partial class VwHrLyLichNv
  {
    public string NhanVien_ID
    {
      get;
      set;
    }
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
    public string QueQuan_FK
    {
      get;
      set;
    }
    public string DanToc_FK
    {
      get;
      set;
    }
    public string TonGiao_FK
    {
      get;
      set;
    }
    public string QuocTich_FK
    {
      get;
      set;
    }
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
    public string TinhTPHoKhau_FK
    {
      get;
      set;
    }
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
    public string TinhTPChoOHienNay_FK
    {
      get;
      set;
    }
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
    public DateTime? NgayNhatTu
    {
      get;
      set;
    }
  }
}
