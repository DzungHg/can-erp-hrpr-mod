using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_Ngach", Schema = "dbo")]
  public partial class TblHpNgach
  {
    [Key]
    public string Ngach_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }

    public ICollection<TblHpBac> TblHpBacs { get; set; }
    public string Ngach_Name
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
