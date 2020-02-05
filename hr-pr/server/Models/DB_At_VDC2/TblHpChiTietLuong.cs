using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChiTietLuong", Schema = "dbo")]
  public partial class TblHpChiTietLuong
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChiTietLuong_SEQ
    {
      get;
      set;
    }
    public string NhanVien_FK
    {
      get;
      set;
    }
    public TblHpNhanVien TblHpNhanVien { get; set; }
    public DateTime? NgayHuongLuong
    {
      get;
      set;
    }
    public string QuyetDinhSo
    {
      get;
      set;
    }
    public DateTime? NgayKy
    {
      get;
      set;
    }
    public string CoQuanKy
    {
      get;
      set;
    }
    public string Ngach
    {
      get;
      set;
    }
    public string Bac
    {
      get;
      set;
    }
    public double? HeSoLuong
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
    public string DienGiai
    {
      get;
      set;
    }
  }
}
