using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChiTietNgoaiNgu", Schema = "dbo")]
  public partial class TblHpChiTietNgoaiNgu
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChiTietNgoaiNgu_SEQ
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
    public string NgoaiNgu_FK
    {
      get;
      set;
    }
    public string TrinhDo_FK
    {
      get;
      set;
    }
    public string VanBang
    {
      get;
      set;
    }
  }
}
