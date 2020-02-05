using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChiTietChuyenMon", Schema = "dbo")]
  public partial class TblHpChiTietChuyenMon
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChiTietChuyenMon_SEQ
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
    public string BangCap_FK
    {
      get;
      set;
    }
    public string Nganh_FK
    {
      get;
      set;
    }
    public string HeDaoTao_FK
    {
      get;
      set;
    }
  }
}
