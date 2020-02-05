using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChiTietCongTac", Schema = "dbo")]
  public partial class TblHpChiTietCongTac
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChiTietCongTac_SEQ
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
    public DateTime? NgayBienDong
    {
      get;
      set;
    }
    public string QuyetDinhSo
    {
      get;
      set;
    }
    public string DonViCu
    {
      get;
      set;
    }
    public string ChucVuCu
    {
      get;
      set;
    }
    public string DonViHienNay
    {
      get;
      set;
    }
    public string ChucVuHienNay
    {
      get;
      set;
    }
  }
}
