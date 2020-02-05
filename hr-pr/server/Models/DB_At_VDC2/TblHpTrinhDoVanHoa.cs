using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_TrinhDoVanHoa", Schema = "dbo")]
  public partial class TblHpTrinhDoVanHoa
  {
    [Key]
    public string TrinhDoVanHoa_ID
    {
      get;
      set;
    }


    public ICollection<TblHpNhanVien> TblHpNhanViens { get; set; }
    public string TrinhDoVanHoa_Name
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
