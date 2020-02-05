using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_PhanLoaiNV", Schema = "dbo")]
  public partial class TblHpPhanLoaiNv
  {
    [Key]
    public string PhanLoaiNV_ID
    {
      get;
      set;
    }
    public string PhanLoaiNV_Name
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
  }
}
