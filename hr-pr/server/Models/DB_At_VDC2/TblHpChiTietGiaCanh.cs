using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChiTietGiaCanh", Schema = "dbo")]
  public partial class TblHpChiTietGiaCanh
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChiTietGiaCanh_SEQ
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
    public string HoVaTen
    {
      get;
      set;
    }
    public Int16? NamSinh
    {
      get;
      set;
    }
    public bool? PhaiNam
    {
      get;
      set;
    }
    public string QuanHe
    {
      get;
      set;
    }
    public string NgheNghiep
    {
      get;
      set;
    }
    public bool? DaChet
    {
      get;
      set;
    }
  }
}
