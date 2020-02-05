using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_DanToc", Schema = "dbo")]
  public partial class TblHpDanToc
  {
    [Key]
    public string DanToc_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string DanToc_Name
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
