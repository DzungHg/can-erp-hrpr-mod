using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_XiNghiep", Schema = "dbo")]
  public partial class TblHpXiNghiep
  {
    [Key]
    public string XiNghiep_ID
    {
      get;
      set;
    }
    public string XiNghiep_Name
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
