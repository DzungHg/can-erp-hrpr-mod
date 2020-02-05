using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_Nganh", Schema = "dbo")]
  public partial class TblHpNganh
  {
    [Key]
    public string Nganh_ID
    {
      get;
      set;
    }
    public string Nganh_Name
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
