using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using CanErpHrPr.Models.DbAtVdc2;

namespace CanErpHrPr.Data
{
  public partial class DbAtVdc2Context : Microsoft.EntityFrameworkCore.DbContext
  {
    public DbAtVdc2Context(DbContextOptions<DbAtVdc2Context> options):base(options)
    {
    }

    public DbAtVdc2Context()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>().HasNoKey();
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpBac>()
              .HasOne(i => i.TblHpNgach)
              .WithMany(i => i.TblHpBacs)
              .HasForeignKey(i => i.Ngach_FK)
              .HasPrincipalKey(i => i.Ngach_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon>()
              .HasOne(i => i.TblHpNhanVien)
              .WithMany(i => i.TblHpChiTietChuyenMons)
              .HasForeignKey(i => i.NhanVien_FK)
              .HasPrincipalKey(i => i.NhanVien_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>()
              .HasOne(i => i.TblHpNhanVien)
              .WithMany(i => i.TblHpChiTietCongTacs)
              .HasForeignKey(i => i.NhanVien_FK)
              .HasPrincipalKey(i => i.NhanVien_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>()
              .HasOne(i => i.TblHpNhanVien)
              .WithMany(i => i.TblHpChiTietGiaCanhs)
              .HasForeignKey(i => i.NhanVien_FK)
              .HasPrincipalKey(i => i.NhanVien_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong>()
              .HasOne(i => i.TblHpNhanVien)
              .WithMany(i => i.TblHpChiTietLuongs)
              .HasForeignKey(i => i.NhanVien_FK)
              .HasPrincipalKey(i => i.NhanVien_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu>()
              .HasOne(i => i.TblHpNhanVien)
              .WithMany(i => i.TblHpChiTietNgoaiNgus)
              .HasForeignKey(i => i.NhanVien_FK)
              .HasPrincipalKey(i => i.NhanVien_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTinhTp)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.NoiSinh_FK)
              .HasPrincipalKey(i => i.TinhTP_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTinhTp1)
              .WithMany(i => i.TblHpNhanViens1)
              .HasForeignKey(i => i.QueQuan_FK)
              .HasPrincipalKey(i => i.TinhTP_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpDanToc)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.DanToc_FK)
              .HasPrincipalKey(i => i.DanToc_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTonGiao)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.TonGiao_FK)
              .HasPrincipalKey(i => i.TonGiao_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpQuocTich)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.QuocTich_FK)
              .HasPrincipalKey(i => i.QuocTich_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpQuan)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.QuanHoKhau_FK)
              .HasPrincipalKey(i => i.Quan_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTinhTp2)
              .WithMany(i => i.TblHpNhanViens2)
              .HasForeignKey(i => i.TinhTPHoKhau_FK)
              .HasPrincipalKey(i => i.TinhTP_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpQuan1)
              .WithMany(i => i.TblHpNhanViens1)
              .HasForeignKey(i => i.QuanChoOHienNay_FK)
              .HasPrincipalKey(i => i.Quan_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTinhTp3)
              .WithMany(i => i.TblHpNhanViens3)
              .HasForeignKey(i => i.TinhTPChoOHienNay_FK)
              .HasPrincipalKey(i => i.TinhTP_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblGnDepartment)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.Department_FK)
              .HasPrincipalKey(i => i.Department_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpDonViTo)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.DonViTo_FK)
              .HasPrincipalKey(i => i.DonViTo_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpChucVu)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.ChucVu_FK)
              .HasPrincipalKey(i => i.ChucVu_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpTrinhDoVanHoa)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.TrinhDoHocVan_FK)
              .HasPrincipalKey(i => i.TrinhDoVanHoa_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpNgach)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.Ngach_FK)
              .HasPrincipalKey(i => i.Ngach_ID);
        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .HasOne(i => i.TblHpBac)
              .WithMany(i => i.TblHpNhanViens)
              .HasForeignKey(i => i.Bac_FK)
              .HasPrincipalKey(i => i.Bac_ID);

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .Property(p => p.NgayNhatTu)
              .HasDefaultValueSql("(getdate())");


        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>()
              .Property(p => p.NgayBienDong)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong>()
              .Property(p => p.NgayHuongLuong)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong>()
              .Property(p => p.NgayKy)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .Property(p => p.NgayThangNamSinh)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .Property(p => p.NgayCapCMND)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .Property(p => p.NgayNghiViec)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien>()
              .Property(p => p.NgayNhatTu)
              .HasColumnType("datetime");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>()
              .Property(p => p.NgayThangNamSinh)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>()
              .Property(p => p.NgayCapCMND)
              .HasColumnType("date");

        builder.Entity<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>()
              .Property(p => p.NgayNhatTu)
              .HasColumnType("datetime");

        this.OnModelBuilding(builder);
    }


    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment> TblGnDepartments
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpBac> TblHpBacs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon> TblHpChiTietChuyenMons
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac> TblHpChiTietCongTacs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh> TblHpChiTietGiaCanhs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong> TblHpChiTietLuongs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu> TblHpChiTietNgoaiNgus
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> TblHpChucVus
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> TblHpDanTocs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> TblHpDonViTos
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao> TblHpHeDaoTaos
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong> TblHpLoaiChamCongs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> TblHpNgaches
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpNganh> TblHpNganhs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu> TblHpNgoaiNgus
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> TblHpNhanViens
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv> TblHpPhanLoaiNvs
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> TblHpQuans
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich> TblHpQuocTiches
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpTinhTp> TblHpTinhTps
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> TblHpTonGiaos
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon> TblHpTrinhDoChuyenMons
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> TblHpTrinhDoVanHoas
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep> TblHpXiNghieps
    {
      get;
      set;
    }

    public DbSet<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv> VwHrLyLichNvs
    {
      get;
      set;
    }
  }
}
