using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_QuocTich", Schema = "dbo")]
  public partial class TblHpQuocTich
  {
    [Key]
    public string QuocTich_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string QuocTich_Name
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
