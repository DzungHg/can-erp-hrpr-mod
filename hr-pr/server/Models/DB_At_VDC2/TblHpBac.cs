using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_Bac", Schema = "dbo")]
  public partial class TblHpBac
  {
    [Key]
    public string Bac_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string Bac_Name
    {
      get;
      set;
    }
    public double? HeSoLuong
    {
      get;
      set;
    }
    public string Ngach_FK
    {
      get;
      set;
    }
    public TblHpNgach TblHpNgach { get; set; }
    public string Description
    {
      get;
      set;
    }
  }
}
