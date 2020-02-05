using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_TrinhDoChuyenMon", Schema = "dbo")]
  public partial class TblHpTrinhDoChuyenMon
  {
    [Key]
    public string TrinhDoChuyenMon_ID
    {
      get;
      set;
    }
    public string TrinhDoChuyenMon_Name
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
