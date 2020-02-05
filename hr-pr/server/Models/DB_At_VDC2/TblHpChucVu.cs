using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_ChucVu", Schema = "dbo")]
  public partial class TblHpChucVu
  {
    [Key]
    public string ChucVu_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string ChucVu_Name
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
