using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_NgoaiNgu", Schema = "dbo")]
  public partial class TblHpNgoaiNgu
  {
    [Key]
    public string NgoaiNgu_ID
    {
      get;
      set;
    }
    public string NgoaiNgu_Name
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
