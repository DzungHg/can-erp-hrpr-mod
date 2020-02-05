using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanErpHrPr.Models.DbAtVdc2
{
  [Table("tblHP_LoaiChamCong", Schema = "dbo")]
  public partial class TblHpLoaiChamCong
  {
    [Key]
    public string LoaiChamCong_ID
    {
      get;
      set;
    }
    public string LoaiChamCong_Name
    {
      get;
      set;
    }
    public double? TyLeHuongLuong
    {
      get;
      set;
    }
    public bool? HuongLuongCoBan
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
