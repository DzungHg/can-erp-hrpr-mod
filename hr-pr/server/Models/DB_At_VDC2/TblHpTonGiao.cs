using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_TonGiao", Schema = "dbo")]
  public partial class TblHpTonGiao
  {
    [Key]
    public string TonGiao_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string TonGiao_Name
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
