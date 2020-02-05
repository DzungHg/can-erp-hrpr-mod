using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblGN_Department", Schema = "dbo")]
  public partial class TblGnDepartment
  {
    [Key]
    public string Department_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string Deparment_Name
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
