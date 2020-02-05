using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_HeDaoTao", Schema = "dbo")]
  public partial class TblHpHeDaoTao
  {
    [Key]
    public string HeDaoTao_ID
    {
      get;
      set;
    }
    public string HeDaoTao_Name
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
