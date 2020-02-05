using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_Quan", Schema = "dbo")]
  public partial class TblHpQuan
  {
    [Key]
    public string Quan_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }

    public ICollection<TblHpNhanVien> TblHpNhanViens1 { get; set; }
    public string Quan_Name
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
