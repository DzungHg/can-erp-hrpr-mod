using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_DonViTo", Schema = "dbo")]
  public partial class TblHpDonViTo
  {
    [Key]
    public string DonViTo_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string DonViTo_Name
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
