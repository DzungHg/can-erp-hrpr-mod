using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_TinhTP", Schema = "dbo")]
  public partial class TblHpTinhTp
  {
    [Key]
    public string TinhTP_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }

    public ICollection<TblHpNhanVien> TblHpNhanViens1 { get; set; }

    public ICollection<TblHpNhanVien> TblHpNhanViens2 { get; set; }

    public ICollection<TblHpNhanVien> TblHpNhanViens3 { get; set; }
    public string TinhTP_Name
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
