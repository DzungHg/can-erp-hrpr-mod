using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using CanErpHrPr.Data;

namespace CanErpHrPr
{
    public partial class DbAtVdc2Service
    {
        private readonly DbAtVdc2Context context;
        private readonly NavigationManager navigationManager;

        public DbAtVdc2Service(DbAtVdc2Context context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportTblGnDepartmentsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblgndepartments/excel") : "export/dbatvdc2/tblgndepartments/excel", true);
        }

        public async Task ExportTblGnDepartmentsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblgndepartments/csv") : "export/dbatvdc2/tblgndepartments/csv", true);
        }

        partial void OnTblGnDepartmentsRead(ref IQueryable<Models.DbAtVdc2.TblGnDepartment> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblGnDepartment>> GetTblGnDepartments(Query query = null)
        {
            var items = context.TblGnDepartments.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnDepartmentsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnDepartmentCreated(Models.DbAtVdc2.TblGnDepartment item);

        public async Task<Models.DbAtVdc2.TblGnDepartment> CreateTblGnDepartment(Models.DbAtVdc2.TblGnDepartment tblGnDepartment)
        {
            OnTblGnDepartmentCreated(tblGnDepartment);

            context.TblGnDepartments.Add(tblGnDepartment);
            context.SaveChanges();

            return tblGnDepartment;
        }
        public async Task ExportTblHpBacsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpbacs/excel") : "export/dbatvdc2/tblhpbacs/excel", true);
        }

        public async Task ExportTblHpBacsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpbacs/csv") : "export/dbatvdc2/tblhpbacs/csv", true);
        }

        partial void OnTblHpBacsRead(ref IQueryable<Models.DbAtVdc2.TblHpBac> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpBac>> GetTblHpBacs(Query query = null)
        {
            var items = context.TblHpBacs.AsQueryable();

            items = items.Include(i => i.TblHpNgach);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpBacsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpBacCreated(Models.DbAtVdc2.TblHpBac item);

        public async Task<Models.DbAtVdc2.TblHpBac> CreateTblHpBac(Models.DbAtVdc2.TblHpBac tblHpBac)
        {
            OnTblHpBacCreated(tblHpBac);

            context.TblHpBacs.Add(tblHpBac);
            context.SaveChanges();

            return tblHpBac;
        }
        public async Task ExportTblHpChiTietChuyenMonsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietchuyenmons/excel") : "export/dbatvdc2/tblhpchitietchuyenmons/excel", true);
        }

        public async Task ExportTblHpChiTietChuyenMonsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietchuyenmons/csv") : "export/dbatvdc2/tblhpchitietchuyenmons/csv", true);
        }

        partial void OnTblHpChiTietChuyenMonsRead(ref IQueryable<Models.DbAtVdc2.TblHpChiTietChuyenMon> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChiTietChuyenMon>> GetTblHpChiTietChuyenMons(Query query = null)
        {
            var items = context.TblHpChiTietChuyenMons.AsQueryable();

            items = items.Include(i => i.TblHpNhanVien);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChiTietChuyenMonsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChiTietChuyenMonCreated(Models.DbAtVdc2.TblHpChiTietChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpChiTietChuyenMon> CreateTblHpChiTietChuyenMon(Models.DbAtVdc2.TblHpChiTietChuyenMon tblHpChiTietChuyenMon)
        {
            OnTblHpChiTietChuyenMonCreated(tblHpChiTietChuyenMon);

            context.TblHpChiTietChuyenMons.Add(tblHpChiTietChuyenMon);
            context.SaveChanges();

            return tblHpChiTietChuyenMon;
        }
        public async Task ExportTblHpChiTietCongTacsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietcongtacs/excel") : "export/dbatvdc2/tblhpchitietcongtacs/excel", true);
        }

        public async Task ExportTblHpChiTietCongTacsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietcongtacs/csv") : "export/dbatvdc2/tblhpchitietcongtacs/csv", true);
        }

        partial void OnTblHpChiTietCongTacsRead(ref IQueryable<Models.DbAtVdc2.TblHpChiTietCongTac> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChiTietCongTac>> GetTblHpChiTietCongTacs(Query query = null)
        {
            var items = context.TblHpChiTietCongTacs.AsQueryable();

            items = items.Include(i => i.TblHpNhanVien);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChiTietCongTacsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChiTietCongTacCreated(Models.DbAtVdc2.TblHpChiTietCongTac item);

        public async Task<Models.DbAtVdc2.TblHpChiTietCongTac> CreateTblHpChiTietCongTac(Models.DbAtVdc2.TblHpChiTietCongTac tblHpChiTietCongTac)
        {
            OnTblHpChiTietCongTacCreated(tblHpChiTietCongTac);

            context.TblHpChiTietCongTacs.Add(tblHpChiTietCongTac);
            context.SaveChanges();

            return tblHpChiTietCongTac;
        }
        public async Task ExportTblHpChiTietGiaCanhsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietgiacanhs/excel") : "export/dbatvdc2/tblhpchitietgiacanhs/excel", true);
        }

        public async Task ExportTblHpChiTietGiaCanhsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietgiacanhs/csv") : "export/dbatvdc2/tblhpchitietgiacanhs/csv", true);
        }

        partial void OnTblHpChiTietGiaCanhsRead(ref IQueryable<Models.DbAtVdc2.TblHpChiTietGiaCanh> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChiTietGiaCanh>> GetTblHpChiTietGiaCanhs(Query query = null)
        {
            var items = context.TblHpChiTietGiaCanhs.AsQueryable();

            items = items.Include(i => i.TblHpNhanVien);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChiTietGiaCanhsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChiTietGiaCanhCreated(Models.DbAtVdc2.TblHpChiTietGiaCanh item);

        public async Task<Models.DbAtVdc2.TblHpChiTietGiaCanh> CreateTblHpChiTietGiaCanh(Models.DbAtVdc2.TblHpChiTietGiaCanh tblHpChiTietGiaCanh)
        {
            OnTblHpChiTietGiaCanhCreated(tblHpChiTietGiaCanh);

            context.TblHpChiTietGiaCanhs.Add(tblHpChiTietGiaCanh);
            context.SaveChanges();

            return tblHpChiTietGiaCanh;
        }
        public async Task ExportTblHpChiTietLuongsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietluongs/excel") : "export/dbatvdc2/tblhpchitietluongs/excel", true);
        }

        public async Task ExportTblHpChiTietLuongsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietluongs/csv") : "export/dbatvdc2/tblhpchitietluongs/csv", true);
        }

        partial void OnTblHpChiTietLuongsRead(ref IQueryable<Models.DbAtVdc2.TblHpChiTietLuong> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChiTietLuong>> GetTblHpChiTietLuongs(Query query = null)
        {
            var items = context.TblHpChiTietLuongs.AsQueryable();

            items = items.Include(i => i.TblHpNhanVien);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChiTietLuongsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChiTietLuongCreated(Models.DbAtVdc2.TblHpChiTietLuong item);

        public async Task<Models.DbAtVdc2.TblHpChiTietLuong> CreateTblHpChiTietLuong(Models.DbAtVdc2.TblHpChiTietLuong tblHpChiTietLuong)
        {
            OnTblHpChiTietLuongCreated(tblHpChiTietLuong);

            context.TblHpChiTietLuongs.Add(tblHpChiTietLuong);
            context.SaveChanges();

            return tblHpChiTietLuong;
        }
        public async Task ExportTblHpChiTietNgoaiNgusToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietngoaingus/excel") : "export/dbatvdc2/tblhpchitietngoaingus/excel", true);
        }

        public async Task ExportTblHpChiTietNgoaiNgusToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchitietngoaingus/csv") : "export/dbatvdc2/tblhpchitietngoaingus/csv", true);
        }

        partial void OnTblHpChiTietNgoaiNgusRead(ref IQueryable<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChiTietNgoaiNgu>> GetTblHpChiTietNgoaiNgus(Query query = null)
        {
            var items = context.TblHpChiTietNgoaiNgus.AsQueryable();

            items = items.Include(i => i.TblHpNhanVien);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChiTietNgoaiNgusRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChiTietNgoaiNguCreated(Models.DbAtVdc2.TblHpChiTietNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> CreateTblHpChiTietNgoaiNgu(Models.DbAtVdc2.TblHpChiTietNgoaiNgu tblHpChiTietNgoaiNgu)
        {
            OnTblHpChiTietNgoaiNguCreated(tblHpChiTietNgoaiNgu);

            context.TblHpChiTietNgoaiNgus.Add(tblHpChiTietNgoaiNgu);
            context.SaveChanges();

            return tblHpChiTietNgoaiNgu;
        }
        public async Task ExportTblHpChucVusToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchucvus/excel") : "export/dbatvdc2/tblhpchucvus/excel", true);
        }

        public async Task ExportTblHpChucVusToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpchucvus/csv") : "export/dbatvdc2/tblhpchucvus/csv", true);
        }

        partial void OnTblHpChucVusRead(ref IQueryable<Models.DbAtVdc2.TblHpChucVu> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpChucVu>> GetTblHpChucVus(Query query = null)
        {
            var items = context.TblHpChucVus.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpChucVusRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpChucVuCreated(Models.DbAtVdc2.TblHpChucVu item);

        public async Task<Models.DbAtVdc2.TblHpChucVu> CreateTblHpChucVu(Models.DbAtVdc2.TblHpChucVu tblHpChucVu)
        {
            OnTblHpChucVuCreated(tblHpChucVu);

            context.TblHpChucVus.Add(tblHpChucVu);
            context.SaveChanges();

            return tblHpChucVu;
        }
        public async Task ExportTblHpDanTocsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpdantocs/excel") : "export/dbatvdc2/tblhpdantocs/excel", true);
        }

        public async Task ExportTblHpDanTocsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpdantocs/csv") : "export/dbatvdc2/tblhpdantocs/csv", true);
        }

        partial void OnTblHpDanTocsRead(ref IQueryable<Models.DbAtVdc2.TblHpDanToc> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpDanToc>> GetTblHpDanTocs(Query query = null)
        {
            var items = context.TblHpDanTocs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpDanTocsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpDanTocCreated(Models.DbAtVdc2.TblHpDanToc item);

        public async Task<Models.DbAtVdc2.TblHpDanToc> CreateTblHpDanToc(Models.DbAtVdc2.TblHpDanToc tblHpDanToc)
        {
            OnTblHpDanTocCreated(tblHpDanToc);

            context.TblHpDanTocs.Add(tblHpDanToc);
            context.SaveChanges();

            return tblHpDanToc;
        }
        public async Task ExportTblHpDonViTosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpdonvitos/excel") : "export/dbatvdc2/tblhpdonvitos/excel", true);
        }

        public async Task ExportTblHpDonViTosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpdonvitos/csv") : "export/dbatvdc2/tblhpdonvitos/csv", true);
        }

        partial void OnTblHpDonViTosRead(ref IQueryable<Models.DbAtVdc2.TblHpDonViTo> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpDonViTo>> GetTblHpDonViTos(Query query = null)
        {
            var items = context.TblHpDonViTos.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpDonViTosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpDonViToCreated(Models.DbAtVdc2.TblHpDonViTo item);

        public async Task<Models.DbAtVdc2.TblHpDonViTo> CreateTblHpDonViTo(Models.DbAtVdc2.TblHpDonViTo tblHpDonViTo)
        {
            OnTblHpDonViToCreated(tblHpDonViTo);

            context.TblHpDonViTos.Add(tblHpDonViTo);
            context.SaveChanges();

            return tblHpDonViTo;
        }
        public async Task ExportTblHpHeDaoTaosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhphedaotaos/excel") : "export/dbatvdc2/tblhphedaotaos/excel", true);
        }

        public async Task ExportTblHpHeDaoTaosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhphedaotaos/csv") : "export/dbatvdc2/tblhphedaotaos/csv", true);
        }

        partial void OnTblHpHeDaoTaosRead(ref IQueryable<Models.DbAtVdc2.TblHpHeDaoTao> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpHeDaoTao>> GetTblHpHeDaoTaos(Query query = null)
        {
            var items = context.TblHpHeDaoTaos.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpHeDaoTaosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpHeDaoTaoCreated(Models.DbAtVdc2.TblHpHeDaoTao item);

        public async Task<Models.DbAtVdc2.TblHpHeDaoTao> CreateTblHpHeDaoTao(Models.DbAtVdc2.TblHpHeDaoTao tblHpHeDaoTao)
        {
            OnTblHpHeDaoTaoCreated(tblHpHeDaoTao);

            context.TblHpHeDaoTaos.Add(tblHpHeDaoTao);
            context.SaveChanges();

            return tblHpHeDaoTao;
        }
        public async Task ExportTblHpLoaiChamCongsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhploaichamcongs/excel") : "export/dbatvdc2/tblhploaichamcongs/excel", true);
        }

        public async Task ExportTblHpLoaiChamCongsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhploaichamcongs/csv") : "export/dbatvdc2/tblhploaichamcongs/csv", true);
        }

        partial void OnTblHpLoaiChamCongsRead(ref IQueryable<Models.DbAtVdc2.TblHpLoaiChamCong> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpLoaiChamCong>> GetTblHpLoaiChamCongs(Query query = null)
        {
            var items = context.TblHpLoaiChamCongs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpLoaiChamCongsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpLoaiChamCongCreated(Models.DbAtVdc2.TblHpLoaiChamCong item);

        public async Task<Models.DbAtVdc2.TblHpLoaiChamCong> CreateTblHpLoaiChamCong(Models.DbAtVdc2.TblHpLoaiChamCong tblHpLoaiChamCong)
        {
            OnTblHpLoaiChamCongCreated(tblHpLoaiChamCong);

            context.TblHpLoaiChamCongs.Add(tblHpLoaiChamCong);
            context.SaveChanges();

            return tblHpLoaiChamCong;
        }
        public async Task ExportTblHpNgachesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpngaches/excel") : "export/dbatvdc2/tblhpngaches/excel", true);
        }

        public async Task ExportTblHpNgachesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpngaches/csv") : "export/dbatvdc2/tblhpngaches/csv", true);
        }

        partial void OnTblHpNgachesRead(ref IQueryable<Models.DbAtVdc2.TblHpNgach> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpNgach>> GetTblHpNgaches(Query query = null)
        {
            var items = context.TblHpNgaches.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpNgachesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpNgachCreated(Models.DbAtVdc2.TblHpNgach item);

        public async Task<Models.DbAtVdc2.TblHpNgach> CreateTblHpNgach(Models.DbAtVdc2.TblHpNgach tblHpNgach)
        {
            OnTblHpNgachCreated(tblHpNgach);

            context.TblHpNgaches.Add(tblHpNgach);
            context.SaveChanges();

            return tblHpNgach;
        }
        public async Task ExportTblHpNganhsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpnganhs/excel") : "export/dbatvdc2/tblhpnganhs/excel", true);
        }

        public async Task ExportTblHpNganhsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpnganhs/csv") : "export/dbatvdc2/tblhpnganhs/csv", true);
        }

        partial void OnTblHpNganhsRead(ref IQueryable<Models.DbAtVdc2.TblHpNganh> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpNganh>> GetTblHpNganhs(Query query = null)
        {
            var items = context.TblHpNganhs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpNganhsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpNganhCreated(Models.DbAtVdc2.TblHpNganh item);

        public async Task<Models.DbAtVdc2.TblHpNganh> CreateTblHpNganh(Models.DbAtVdc2.TblHpNganh tblHpNganh)
        {
            OnTblHpNganhCreated(tblHpNganh);

            context.TblHpNganhs.Add(tblHpNganh);
            context.SaveChanges();

            return tblHpNganh;
        }
        public async Task ExportTblHpNgoaiNgusToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpngoaingus/excel") : "export/dbatvdc2/tblhpngoaingus/excel", true);
        }

        public async Task ExportTblHpNgoaiNgusToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpngoaingus/csv") : "export/dbatvdc2/tblhpngoaingus/csv", true);
        }

        partial void OnTblHpNgoaiNgusRead(ref IQueryable<Models.DbAtVdc2.TblHpNgoaiNgu> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpNgoaiNgu>> GetTblHpNgoaiNgus(Query query = null)
        {
            var items = context.TblHpNgoaiNgus.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpNgoaiNgusRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpNgoaiNguCreated(Models.DbAtVdc2.TblHpNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpNgoaiNgu> CreateTblHpNgoaiNgu(Models.DbAtVdc2.TblHpNgoaiNgu tblHpNgoaiNgu)
        {
            OnTblHpNgoaiNguCreated(tblHpNgoaiNgu);

            context.TblHpNgoaiNgus.Add(tblHpNgoaiNgu);
            context.SaveChanges();

            return tblHpNgoaiNgu;
        }
        public async Task ExportTblHpNhanViensToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpnhanviens/excel") : "export/dbatvdc2/tblhpnhanviens/excel", true);
        }

        public async Task ExportTblHpNhanViensToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpnhanviens/csv") : "export/dbatvdc2/tblhpnhanviens/csv", true);
        }

        partial void OnTblHpNhanViensRead(ref IQueryable<Models.DbAtVdc2.TblHpNhanVien> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpNhanVien>> GetTblHpNhanViens(Query query = null)
        {
            var items = context.TblHpNhanViens.AsQueryable();

            items = items.Include(i => i.TblHpTinhTp);

            items = items.Include(i => i.TblHpTinhTp1);

            items = items.Include(i => i.TblHpDanToc);

            items = items.Include(i => i.TblHpTonGiao);

            items = items.Include(i => i.TblHpQuocTich);

            items = items.Include(i => i.TblHpQuan);

            items = items.Include(i => i.TblHpTinhTp2);

            items = items.Include(i => i.TblHpQuan1);

            items = items.Include(i => i.TblHpTinhTp3);

            items = items.Include(i => i.TblGnDepartment);

            items = items.Include(i => i.TblHpDonViTo);

            items = items.Include(i => i.TblHpChucVu);

            items = items.Include(i => i.TblHpTrinhDoVanHoa);

            items = items.Include(i => i.TblHpNgach);

            items = items.Include(i => i.TblHpBac);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpNhanViensRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpNhanVienCreated(Models.DbAtVdc2.TblHpNhanVien item);

        public async Task<Models.DbAtVdc2.TblHpNhanVien> CreateTblHpNhanVien(Models.DbAtVdc2.TblHpNhanVien tblHpNhanVien)
        {
            OnTblHpNhanVienCreated(tblHpNhanVien);

            context.TblHpNhanViens.Add(tblHpNhanVien);
            context.SaveChanges();

            return tblHpNhanVien;
        }
        public async Task ExportTblHpPhanLoaiNvsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpphanloainvs/excel") : "export/dbatvdc2/tblhpphanloainvs/excel", true);
        }

        public async Task ExportTblHpPhanLoaiNvsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpphanloainvs/csv") : "export/dbatvdc2/tblhpphanloainvs/csv", true);
        }

        partial void OnTblHpPhanLoaiNvsRead(ref IQueryable<Models.DbAtVdc2.TblHpPhanLoaiNv> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpPhanLoaiNv>> GetTblHpPhanLoaiNvs(Query query = null)
        {
            var items = context.TblHpPhanLoaiNvs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpPhanLoaiNvsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpPhanLoaiNvCreated(Models.DbAtVdc2.TblHpPhanLoaiNv item);

        public async Task<Models.DbAtVdc2.TblHpPhanLoaiNv> CreateTblHpPhanLoaiNv(Models.DbAtVdc2.TblHpPhanLoaiNv tblHpPhanLoaiNv)
        {
            OnTblHpPhanLoaiNvCreated(tblHpPhanLoaiNv);

            context.TblHpPhanLoaiNvs.Add(tblHpPhanLoaiNv);
            context.SaveChanges();

            return tblHpPhanLoaiNv;
        }
        public async Task ExportTblHpQuansToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpquans/excel") : "export/dbatvdc2/tblhpquans/excel", true);
        }

        public async Task ExportTblHpQuansToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpquans/csv") : "export/dbatvdc2/tblhpquans/csv", true);
        }

        partial void OnTblHpQuansRead(ref IQueryable<Models.DbAtVdc2.TblHpQuan> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpQuan>> GetTblHpQuans(Query query = null)
        {
            var items = context.TblHpQuans.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpQuansRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpQuanCreated(Models.DbAtVdc2.TblHpQuan item);

        public async Task<Models.DbAtVdc2.TblHpQuan> CreateTblHpQuan(Models.DbAtVdc2.TblHpQuan tblHpQuan)
        {
            OnTblHpQuanCreated(tblHpQuan);

            context.TblHpQuans.Add(tblHpQuan);
            context.SaveChanges();

            return tblHpQuan;
        }
        public async Task ExportTblHpQuocTichesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpquoctiches/excel") : "export/dbatvdc2/tblhpquoctiches/excel", true);
        }

        public async Task ExportTblHpQuocTichesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpquoctiches/csv") : "export/dbatvdc2/tblhpquoctiches/csv", true);
        }

        partial void OnTblHpQuocTichesRead(ref IQueryable<Models.DbAtVdc2.TblHpQuocTich> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpQuocTich>> GetTblHpQuocTiches(Query query = null)
        {
            var items = context.TblHpQuocTiches.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpQuocTichesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpQuocTichCreated(Models.DbAtVdc2.TblHpQuocTich item);

        public async Task<Models.DbAtVdc2.TblHpQuocTich> CreateTblHpQuocTich(Models.DbAtVdc2.TblHpQuocTich tblHpQuocTich)
        {
            OnTblHpQuocTichCreated(tblHpQuocTich);

            context.TblHpQuocTiches.Add(tblHpQuocTich);
            context.SaveChanges();

            return tblHpQuocTich;
        }
        public async Task ExportTblHpTinhTpsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptinhtps/excel") : "export/dbatvdc2/tblhptinhtps/excel", true);
        }

        public async Task ExportTblHpTinhTpsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptinhtps/csv") : "export/dbatvdc2/tblhptinhtps/csv", true);
        }

        partial void OnTblHpTinhTpsRead(ref IQueryable<Models.DbAtVdc2.TblHpTinhTp> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpTinhTp>> GetTblHpTinhTps(Query query = null)
        {
            var items = context.TblHpTinhTps.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpTinhTpsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpTinhTpCreated(Models.DbAtVdc2.TblHpTinhTp item);

        public async Task<Models.DbAtVdc2.TblHpTinhTp> CreateTblHpTinhTp(Models.DbAtVdc2.TblHpTinhTp tblHpTinhTp)
        {
            OnTblHpTinhTpCreated(tblHpTinhTp);

            context.TblHpTinhTps.Add(tblHpTinhTp);
            context.SaveChanges();

            return tblHpTinhTp;
        }
        public async Task ExportTblHpTonGiaosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptongiaos/excel") : "export/dbatvdc2/tblhptongiaos/excel", true);
        }

        public async Task ExportTblHpTonGiaosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptongiaos/csv") : "export/dbatvdc2/tblhptongiaos/csv", true);
        }

        partial void OnTblHpTonGiaosRead(ref IQueryable<Models.DbAtVdc2.TblHpTonGiao> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpTonGiao>> GetTblHpTonGiaos(Query query = null)
        {
            var items = context.TblHpTonGiaos.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpTonGiaosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpTonGiaoCreated(Models.DbAtVdc2.TblHpTonGiao item);

        public async Task<Models.DbAtVdc2.TblHpTonGiao> CreateTblHpTonGiao(Models.DbAtVdc2.TblHpTonGiao tblHpTonGiao)
        {
            OnTblHpTonGiaoCreated(tblHpTonGiao);

            context.TblHpTonGiaos.Add(tblHpTonGiao);
            context.SaveChanges();

            return tblHpTonGiao;
        }
        public async Task ExportTblHpTrinhDoChuyenMonsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptrinhdochuyenmons/excel") : "export/dbatvdc2/tblhptrinhdochuyenmons/excel", true);
        }

        public async Task ExportTblHpTrinhDoChuyenMonsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptrinhdochuyenmons/csv") : "export/dbatvdc2/tblhptrinhdochuyenmons/csv", true);
        }

        partial void OnTblHpTrinhDoChuyenMonsRead(ref IQueryable<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpTrinhDoChuyenMon>> GetTblHpTrinhDoChuyenMons(Query query = null)
        {
            var items = context.TblHpTrinhDoChuyenMons.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpTrinhDoChuyenMonsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpTrinhDoChuyenMonCreated(Models.DbAtVdc2.TblHpTrinhDoChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> CreateTblHpTrinhDoChuyenMon(Models.DbAtVdc2.TblHpTrinhDoChuyenMon tblHpTrinhDoChuyenMon)
        {
            OnTblHpTrinhDoChuyenMonCreated(tblHpTrinhDoChuyenMon);

            context.TblHpTrinhDoChuyenMons.Add(tblHpTrinhDoChuyenMon);
            context.SaveChanges();

            return tblHpTrinhDoChuyenMon;
        }
        public async Task ExportTblHpTrinhDoVanHoasToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptrinhdovanhoas/excel") : "export/dbatvdc2/tblhptrinhdovanhoas/excel", true);
        }

        public async Task ExportTblHpTrinhDoVanHoasToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhptrinhdovanhoas/csv") : "export/dbatvdc2/tblhptrinhdovanhoas/csv", true);
        }

        partial void OnTblHpTrinhDoVanHoasRead(ref IQueryable<Models.DbAtVdc2.TblHpTrinhDoVanHoa> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpTrinhDoVanHoa>> GetTblHpTrinhDoVanHoas(Query query = null)
        {
            var items = context.TblHpTrinhDoVanHoas.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpTrinhDoVanHoasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpTrinhDoVanHoaCreated(Models.DbAtVdc2.TblHpTrinhDoVanHoa item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoVanHoa> CreateTblHpTrinhDoVanHoa(Models.DbAtVdc2.TblHpTrinhDoVanHoa tblHpTrinhDoVanHoa)
        {
            OnTblHpTrinhDoVanHoaCreated(tblHpTrinhDoVanHoa);

            context.TblHpTrinhDoVanHoas.Add(tblHpTrinhDoVanHoa);
            context.SaveChanges();

            return tblHpTrinhDoVanHoa;
        }
        public async Task ExportTblHpXiNghiepsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpxinghieps/excel") : "export/dbatvdc2/tblhpxinghieps/excel", true);
        }

        public async Task ExportTblHpXiNghiepsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/tblhpxinghieps/csv") : "export/dbatvdc2/tblhpxinghieps/csv", true);
        }

        partial void OnTblHpXiNghiepsRead(ref IQueryable<Models.DbAtVdc2.TblHpXiNghiep> items);

        public async Task<IQueryable<Models.DbAtVdc2.TblHpXiNghiep>> GetTblHpXiNghieps(Query query = null)
        {
            var items = context.TblHpXiNghieps.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblHpXiNghiepsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblHpXiNghiepCreated(Models.DbAtVdc2.TblHpXiNghiep item);

        public async Task<Models.DbAtVdc2.TblHpXiNghiep> CreateTblHpXiNghiep(Models.DbAtVdc2.TblHpXiNghiep tblHpXiNghiep)
        {
            OnTblHpXiNghiepCreated(tblHpXiNghiep);

            context.TblHpXiNghieps.Add(tblHpXiNghiep);
            context.SaveChanges();

            return tblHpXiNghiep;
        }
        public async Task ExportVwHrLyLichNvsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/vwhrlylichnvs/excel") : "export/dbatvdc2/vwhrlylichnvs/excel", true);
        }

        public async Task ExportVwHrLyLichNvsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/dbatvdc2/vwhrlylichnvs/csv") : "export/dbatvdc2/vwhrlylichnvs/csv", true);
        }

        partial void OnVwHrLyLichNvsRead(ref IQueryable<Models.DbAtVdc2.VwHrLyLichNv> items);

        public async Task<IQueryable<Models.DbAtVdc2.VwHrLyLichNv>> GetVwHrLyLichNvs(Query query = null)
        {
            var items = context.VwHrLyLichNvs.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVwHrLyLichNvsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnDepartmentDeleted(Models.DbAtVdc2.TblGnDepartment item);

        public async Task<Models.DbAtVdc2.TblGnDepartment> DeleteTblGnDepartment(string departmentId)
        {
            var item = context.TblGnDepartments
                              .Where(i => i.Department_ID == departmentId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblGnDepartmentDeleted(item);

            context.TblGnDepartments.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnDepartmentGet(Models.DbAtVdc2.TblGnDepartment item);

        public async Task<Models.DbAtVdc2.TblGnDepartment> GetTblGnDepartmentByDepartmentId(string departmentId)
        {
            var items = context.TblGnDepartments
                              .AsNoTracking()
                              .Where(i => i.Department_ID == departmentId);

            var item = items.FirstOrDefault();

            OnTblGnDepartmentGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblGnDepartment> CancelTblGnDepartmentChanges(Models.DbAtVdc2.TblGnDepartment item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnDepartmentUpdated(Models.DbAtVdc2.TblGnDepartment item);

        public async Task<Models.DbAtVdc2.TblGnDepartment> UpdateTblGnDepartment(string departmentId, Models.DbAtVdc2.TblGnDepartment tblGnDepartment)
        {
            OnTblGnDepartmentUpdated(tblGnDepartment);

            var item = context.TblGnDepartments
                              .Where(i => i.Department_ID == departmentId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnDepartment);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnDepartment;
        }

        partial void OnTblHpBacDeleted(Models.DbAtVdc2.TblHpBac item);

        public async Task<Models.DbAtVdc2.TblHpBac> DeleteTblHpBac(string bacId)
        {
            var item = context.TblHpBacs
                              .Where(i => i.Bac_ID == bacId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpBacDeleted(item);

            context.TblHpBacs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpBacGet(Models.DbAtVdc2.TblHpBac item);

        public async Task<Models.DbAtVdc2.TblHpBac> GetTblHpBacByBacId(string bacId)
        {
            var items = context.TblHpBacs
                              .AsNoTracking()
                              .Where(i => i.Bac_ID == bacId);

            items = items.Include(i => i.TblHpNgach);

            var item = items.FirstOrDefault();

            OnTblHpBacGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpBac> CancelTblHpBacChanges(Models.DbAtVdc2.TblHpBac item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpBacUpdated(Models.DbAtVdc2.TblHpBac item);

        public async Task<Models.DbAtVdc2.TblHpBac> UpdateTblHpBac(string bacId, Models.DbAtVdc2.TblHpBac tblHpBac)
        {
            OnTblHpBacUpdated(tblHpBac);

            var item = context.TblHpBacs
                              .Where(i => i.Bac_ID == bacId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpBac);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpBac;
        }

        partial void OnTblHpChiTietChuyenMonDeleted(Models.DbAtVdc2.TblHpChiTietChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpChiTietChuyenMon> DeleteTblHpChiTietChuyenMon(int? chiTietChuyenMonSeq)
        {
            var item = context.TblHpChiTietChuyenMons
                              .Where(i => i.ChiTietChuyenMon_SEQ == chiTietChuyenMonSeq)
                              .FirstOrDefault();

            OnTblHpChiTietChuyenMonDeleted(item);

            context.TblHpChiTietChuyenMons.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChiTietChuyenMonGet(Models.DbAtVdc2.TblHpChiTietChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpChiTietChuyenMon> GetTblHpChiTietChuyenMonByChiTietChuyenMonSeq(int? chiTietChuyenMonSeq)
        {
            var items = context.TblHpChiTietChuyenMons
                              .AsNoTracking()
                              .Where(i => i.ChiTietChuyenMon_SEQ == chiTietChuyenMonSeq);

            items = items.Include(i => i.TblHpNhanVien);

            var item = items.FirstOrDefault();

            OnTblHpChiTietChuyenMonGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChiTietChuyenMon> CancelTblHpChiTietChuyenMonChanges(Models.DbAtVdc2.TblHpChiTietChuyenMon item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChiTietChuyenMonUpdated(Models.DbAtVdc2.TblHpChiTietChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpChiTietChuyenMon> UpdateTblHpChiTietChuyenMon(int? chiTietChuyenMonSeq, Models.DbAtVdc2.TblHpChiTietChuyenMon tblHpChiTietChuyenMon)
        {
            OnTblHpChiTietChuyenMonUpdated(tblHpChiTietChuyenMon);

            var item = context.TblHpChiTietChuyenMons
                              .Where(i => i.ChiTietChuyenMon_SEQ == chiTietChuyenMonSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChiTietChuyenMon);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChiTietChuyenMon;
        }

        partial void OnTblHpChiTietCongTacDeleted(Models.DbAtVdc2.TblHpChiTietCongTac item);

        public async Task<Models.DbAtVdc2.TblHpChiTietCongTac> DeleteTblHpChiTietCongTac(int? chiTietCongTacSeq)
        {
            var item = context.TblHpChiTietCongTacs
                              .Where(i => i.ChiTietCongTac_SEQ == chiTietCongTacSeq)
                              .FirstOrDefault();

            OnTblHpChiTietCongTacDeleted(item);

            context.TblHpChiTietCongTacs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChiTietCongTacGet(Models.DbAtVdc2.TblHpChiTietCongTac item);

        public async Task<Models.DbAtVdc2.TblHpChiTietCongTac> GetTblHpChiTietCongTacByChiTietCongTacSeq(int? chiTietCongTacSeq)
        {
            var items = context.TblHpChiTietCongTacs
                              .AsNoTracking()
                              .Where(i => i.ChiTietCongTac_SEQ == chiTietCongTacSeq);

            items = items.Include(i => i.TblHpNhanVien);

            var item = items.FirstOrDefault();

            OnTblHpChiTietCongTacGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChiTietCongTac> CancelTblHpChiTietCongTacChanges(Models.DbAtVdc2.TblHpChiTietCongTac item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChiTietCongTacUpdated(Models.DbAtVdc2.TblHpChiTietCongTac item);

        public async Task<Models.DbAtVdc2.TblHpChiTietCongTac> UpdateTblHpChiTietCongTac(int? chiTietCongTacSeq, Models.DbAtVdc2.TblHpChiTietCongTac tblHpChiTietCongTac)
        {
            OnTblHpChiTietCongTacUpdated(tblHpChiTietCongTac);

            var item = context.TblHpChiTietCongTacs
                              .Where(i => i.ChiTietCongTac_SEQ == chiTietCongTacSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChiTietCongTac);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChiTietCongTac;
        }

        partial void OnTblHpChiTietGiaCanhDeleted(Models.DbAtVdc2.TblHpChiTietGiaCanh item);

        public async Task<Models.DbAtVdc2.TblHpChiTietGiaCanh> DeleteTblHpChiTietGiaCanh(int? chiTietGiaCanhSeq)
        {
            var item = context.TblHpChiTietGiaCanhs
                              .Where(i => i.ChiTietGiaCanh_SEQ == chiTietGiaCanhSeq)
                              .FirstOrDefault();

            OnTblHpChiTietGiaCanhDeleted(item);

            context.TblHpChiTietGiaCanhs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChiTietGiaCanhGet(Models.DbAtVdc2.TblHpChiTietGiaCanh item);

        public async Task<Models.DbAtVdc2.TblHpChiTietGiaCanh> GetTblHpChiTietGiaCanhByChiTietGiaCanhSeq(int? chiTietGiaCanhSeq)
        {
            var items = context.TblHpChiTietGiaCanhs
                              .AsNoTracking()
                              .Where(i => i.ChiTietGiaCanh_SEQ == chiTietGiaCanhSeq);

            items = items.Include(i => i.TblHpNhanVien);

            var item = items.FirstOrDefault();

            OnTblHpChiTietGiaCanhGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChiTietGiaCanh> CancelTblHpChiTietGiaCanhChanges(Models.DbAtVdc2.TblHpChiTietGiaCanh item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChiTietGiaCanhUpdated(Models.DbAtVdc2.TblHpChiTietGiaCanh item);

        public async Task<Models.DbAtVdc2.TblHpChiTietGiaCanh> UpdateTblHpChiTietGiaCanh(int? chiTietGiaCanhSeq, Models.DbAtVdc2.TblHpChiTietGiaCanh tblHpChiTietGiaCanh)
        {
            OnTblHpChiTietGiaCanhUpdated(tblHpChiTietGiaCanh);

            var item = context.TblHpChiTietGiaCanhs
                              .Where(i => i.ChiTietGiaCanh_SEQ == chiTietGiaCanhSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChiTietGiaCanh);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChiTietGiaCanh;
        }

        partial void OnTblHpChiTietLuongDeleted(Models.DbAtVdc2.TblHpChiTietLuong item);

        public async Task<Models.DbAtVdc2.TblHpChiTietLuong> DeleteTblHpChiTietLuong(int? chiTietLuongSeq)
        {
            var item = context.TblHpChiTietLuongs
                              .Where(i => i.ChiTietLuong_SEQ == chiTietLuongSeq)
                              .FirstOrDefault();

            OnTblHpChiTietLuongDeleted(item);

            context.TblHpChiTietLuongs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChiTietLuongGet(Models.DbAtVdc2.TblHpChiTietLuong item);

        public async Task<Models.DbAtVdc2.TblHpChiTietLuong> GetTblHpChiTietLuongByChiTietLuongSeq(int? chiTietLuongSeq)
        {
            var items = context.TblHpChiTietLuongs
                              .AsNoTracking()
                              .Where(i => i.ChiTietLuong_SEQ == chiTietLuongSeq);

            items = items.Include(i => i.TblHpNhanVien);

            var item = items.FirstOrDefault();

            OnTblHpChiTietLuongGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChiTietLuong> CancelTblHpChiTietLuongChanges(Models.DbAtVdc2.TblHpChiTietLuong item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChiTietLuongUpdated(Models.DbAtVdc2.TblHpChiTietLuong item);

        public async Task<Models.DbAtVdc2.TblHpChiTietLuong> UpdateTblHpChiTietLuong(int? chiTietLuongSeq, Models.DbAtVdc2.TblHpChiTietLuong tblHpChiTietLuong)
        {
            OnTblHpChiTietLuongUpdated(tblHpChiTietLuong);

            var item = context.TblHpChiTietLuongs
                              .Where(i => i.ChiTietLuong_SEQ == chiTietLuongSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChiTietLuong);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChiTietLuong;
        }

        partial void OnTblHpChiTietNgoaiNguDeleted(Models.DbAtVdc2.TblHpChiTietNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> DeleteTblHpChiTietNgoaiNgu(int? chiTietNgoaiNguSeq)
        {
            var item = context.TblHpChiTietNgoaiNgus
                              .Where(i => i.ChiTietNgoaiNgu_SEQ == chiTietNgoaiNguSeq)
                              .FirstOrDefault();

            OnTblHpChiTietNgoaiNguDeleted(item);

            context.TblHpChiTietNgoaiNgus.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChiTietNgoaiNguGet(Models.DbAtVdc2.TblHpChiTietNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> GetTblHpChiTietNgoaiNguByChiTietNgoaiNguSeq(int? chiTietNgoaiNguSeq)
        {
            var items = context.TblHpChiTietNgoaiNgus
                              .AsNoTracking()
                              .Where(i => i.ChiTietNgoaiNgu_SEQ == chiTietNgoaiNguSeq);

            items = items.Include(i => i.TblHpNhanVien);

            var item = items.FirstOrDefault();

            OnTblHpChiTietNgoaiNguGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> CancelTblHpChiTietNgoaiNguChanges(Models.DbAtVdc2.TblHpChiTietNgoaiNgu item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChiTietNgoaiNguUpdated(Models.DbAtVdc2.TblHpChiTietNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpChiTietNgoaiNgu> UpdateTblHpChiTietNgoaiNgu(int? chiTietNgoaiNguSeq, Models.DbAtVdc2.TblHpChiTietNgoaiNgu tblHpChiTietNgoaiNgu)
        {
            OnTblHpChiTietNgoaiNguUpdated(tblHpChiTietNgoaiNgu);

            var item = context.TblHpChiTietNgoaiNgus
                              .Where(i => i.ChiTietNgoaiNgu_SEQ == chiTietNgoaiNguSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChiTietNgoaiNgu);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChiTietNgoaiNgu;
        }

        partial void OnTblHpChucVuDeleted(Models.DbAtVdc2.TblHpChucVu item);

        public async Task<Models.DbAtVdc2.TblHpChucVu> DeleteTblHpChucVu(string chucVuId)
        {
            var item = context.TblHpChucVus
                              .Where(i => i.ChucVu_ID == chucVuId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpChucVuDeleted(item);

            context.TblHpChucVus.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpChucVuGet(Models.DbAtVdc2.TblHpChucVu item);

        public async Task<Models.DbAtVdc2.TblHpChucVu> GetTblHpChucVuByChucVuId(string chucVuId)
        {
            var items = context.TblHpChucVus
                              .AsNoTracking()
                              .Where(i => i.ChucVu_ID == chucVuId);

            var item = items.FirstOrDefault();

            OnTblHpChucVuGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpChucVu> CancelTblHpChucVuChanges(Models.DbAtVdc2.TblHpChucVu item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpChucVuUpdated(Models.DbAtVdc2.TblHpChucVu item);

        public async Task<Models.DbAtVdc2.TblHpChucVu> UpdateTblHpChucVu(string chucVuId, Models.DbAtVdc2.TblHpChucVu tblHpChucVu)
        {
            OnTblHpChucVuUpdated(tblHpChucVu);

            var item = context.TblHpChucVus
                              .Where(i => i.ChucVu_ID == chucVuId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpChucVu);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpChucVu;
        }

        partial void OnTblHpDanTocDeleted(Models.DbAtVdc2.TblHpDanToc item);

        public async Task<Models.DbAtVdc2.TblHpDanToc> DeleteTblHpDanToc(string danTocId)
        {
            var item = context.TblHpDanTocs
                              .Where(i => i.DanToc_ID == danTocId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpDanTocDeleted(item);

            context.TblHpDanTocs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpDanTocGet(Models.DbAtVdc2.TblHpDanToc item);

        public async Task<Models.DbAtVdc2.TblHpDanToc> GetTblHpDanTocByDanTocId(string danTocId)
        {
            var items = context.TblHpDanTocs
                              .AsNoTracking()
                              .Where(i => i.DanToc_ID == danTocId);

            var item = items.FirstOrDefault();

            OnTblHpDanTocGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpDanToc> CancelTblHpDanTocChanges(Models.DbAtVdc2.TblHpDanToc item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpDanTocUpdated(Models.DbAtVdc2.TblHpDanToc item);

        public async Task<Models.DbAtVdc2.TblHpDanToc> UpdateTblHpDanToc(string danTocId, Models.DbAtVdc2.TblHpDanToc tblHpDanToc)
        {
            OnTblHpDanTocUpdated(tblHpDanToc);

            var item = context.TblHpDanTocs
                              .Where(i => i.DanToc_ID == danTocId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpDanToc);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpDanToc;
        }

        partial void OnTblHpDonViToDeleted(Models.DbAtVdc2.TblHpDonViTo item);

        public async Task<Models.DbAtVdc2.TblHpDonViTo> DeleteTblHpDonViTo(string donViToId)
        {
            var item = context.TblHpDonViTos
                              .Where(i => i.DonViTo_ID == donViToId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpDonViToDeleted(item);

            context.TblHpDonViTos.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpDonViToGet(Models.DbAtVdc2.TblHpDonViTo item);

        public async Task<Models.DbAtVdc2.TblHpDonViTo> GetTblHpDonViToByDonViToId(string donViToId)
        {
            var items = context.TblHpDonViTos
                              .AsNoTracking()
                              .Where(i => i.DonViTo_ID == donViToId);

            var item = items.FirstOrDefault();

            OnTblHpDonViToGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpDonViTo> CancelTblHpDonViToChanges(Models.DbAtVdc2.TblHpDonViTo item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpDonViToUpdated(Models.DbAtVdc2.TblHpDonViTo item);

        public async Task<Models.DbAtVdc2.TblHpDonViTo> UpdateTblHpDonViTo(string donViToId, Models.DbAtVdc2.TblHpDonViTo tblHpDonViTo)
        {
            OnTblHpDonViToUpdated(tblHpDonViTo);

            var item = context.TblHpDonViTos
                              .Where(i => i.DonViTo_ID == donViToId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpDonViTo);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpDonViTo;
        }

        partial void OnTblHpHeDaoTaoDeleted(Models.DbAtVdc2.TblHpHeDaoTao item);

        public async Task<Models.DbAtVdc2.TblHpHeDaoTao> DeleteTblHpHeDaoTao(string heDaoTaoId)
        {
            var item = context.TblHpHeDaoTaos
                              .Where(i => i.HeDaoTao_ID == heDaoTaoId)
                              .FirstOrDefault();

            OnTblHpHeDaoTaoDeleted(item);

            context.TblHpHeDaoTaos.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpHeDaoTaoGet(Models.DbAtVdc2.TblHpHeDaoTao item);

        public async Task<Models.DbAtVdc2.TblHpHeDaoTao> GetTblHpHeDaoTaoByHeDaoTaoId(string heDaoTaoId)
        {
            var items = context.TblHpHeDaoTaos
                              .AsNoTracking()
                              .Where(i => i.HeDaoTao_ID == heDaoTaoId);

            var item = items.FirstOrDefault();

            OnTblHpHeDaoTaoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpHeDaoTao> CancelTblHpHeDaoTaoChanges(Models.DbAtVdc2.TblHpHeDaoTao item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpHeDaoTaoUpdated(Models.DbAtVdc2.TblHpHeDaoTao item);

        public async Task<Models.DbAtVdc2.TblHpHeDaoTao> UpdateTblHpHeDaoTao(string heDaoTaoId, Models.DbAtVdc2.TblHpHeDaoTao tblHpHeDaoTao)
        {
            OnTblHpHeDaoTaoUpdated(tblHpHeDaoTao);

            var item = context.TblHpHeDaoTaos
                              .Where(i => i.HeDaoTao_ID == heDaoTaoId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpHeDaoTao);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpHeDaoTao;
        }

        partial void OnTblHpLoaiChamCongDeleted(Models.DbAtVdc2.TblHpLoaiChamCong item);

        public async Task<Models.DbAtVdc2.TblHpLoaiChamCong> DeleteTblHpLoaiChamCong(string loaiChamCongId)
        {
            var item = context.TblHpLoaiChamCongs
                              .Where(i => i.LoaiChamCong_ID == loaiChamCongId)
                              .FirstOrDefault();

            OnTblHpLoaiChamCongDeleted(item);

            context.TblHpLoaiChamCongs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpLoaiChamCongGet(Models.DbAtVdc2.TblHpLoaiChamCong item);

        public async Task<Models.DbAtVdc2.TblHpLoaiChamCong> GetTblHpLoaiChamCongByLoaiChamCongId(string loaiChamCongId)
        {
            var items = context.TblHpLoaiChamCongs
                              .AsNoTracking()
                              .Where(i => i.LoaiChamCong_ID == loaiChamCongId);

            var item = items.FirstOrDefault();

            OnTblHpLoaiChamCongGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpLoaiChamCong> CancelTblHpLoaiChamCongChanges(Models.DbAtVdc2.TblHpLoaiChamCong item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpLoaiChamCongUpdated(Models.DbAtVdc2.TblHpLoaiChamCong item);

        public async Task<Models.DbAtVdc2.TblHpLoaiChamCong> UpdateTblHpLoaiChamCong(string loaiChamCongId, Models.DbAtVdc2.TblHpLoaiChamCong tblHpLoaiChamCong)
        {
            OnTblHpLoaiChamCongUpdated(tblHpLoaiChamCong);

            var item = context.TblHpLoaiChamCongs
                              .Where(i => i.LoaiChamCong_ID == loaiChamCongId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpLoaiChamCong);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpLoaiChamCong;
        }

        partial void OnTblHpNgachDeleted(Models.DbAtVdc2.TblHpNgach item);

        public async Task<Models.DbAtVdc2.TblHpNgach> DeleteTblHpNgach(string ngachId)
        {
            var item = context.TblHpNgaches
                              .Where(i => i.Ngach_ID == ngachId)
                              .Include(i => i.TblHpNhanViens)
                              .Include(i => i.TblHpBacs)
                              .FirstOrDefault();

            OnTblHpNgachDeleted(item);

            context.TblHpNgaches.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpNgachGet(Models.DbAtVdc2.TblHpNgach item);

        public async Task<Models.DbAtVdc2.TblHpNgach> GetTblHpNgachByNgachId(string ngachId)
        {
            var items = context.TblHpNgaches
                              .AsNoTracking()
                              .Where(i => i.Ngach_ID == ngachId);

            var item = items.FirstOrDefault();

            OnTblHpNgachGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpNgach> CancelTblHpNgachChanges(Models.DbAtVdc2.TblHpNgach item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpNgachUpdated(Models.DbAtVdc2.TblHpNgach item);

        public async Task<Models.DbAtVdc2.TblHpNgach> UpdateTblHpNgach(string ngachId, Models.DbAtVdc2.TblHpNgach tblHpNgach)
        {
            OnTblHpNgachUpdated(tblHpNgach);

            var item = context.TblHpNgaches
                              .Where(i => i.Ngach_ID == ngachId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpNgach);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpNgach;
        }

        partial void OnTblHpNganhDeleted(Models.DbAtVdc2.TblHpNganh item);

        public async Task<Models.DbAtVdc2.TblHpNganh> DeleteTblHpNganh(string nganhId)
        {
            var item = context.TblHpNganhs
                              .Where(i => i.Nganh_ID == nganhId)
                              .FirstOrDefault();

            OnTblHpNganhDeleted(item);

            context.TblHpNganhs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpNganhGet(Models.DbAtVdc2.TblHpNganh item);

        public async Task<Models.DbAtVdc2.TblHpNganh> GetTblHpNganhByNganhId(string nganhId)
        {
            var items = context.TblHpNganhs
                              .AsNoTracking()
                              .Where(i => i.Nganh_ID == nganhId);

            var item = items.FirstOrDefault();

            OnTblHpNganhGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpNganh> CancelTblHpNganhChanges(Models.DbAtVdc2.TblHpNganh item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpNganhUpdated(Models.DbAtVdc2.TblHpNganh item);

        public async Task<Models.DbAtVdc2.TblHpNganh> UpdateTblHpNganh(string nganhId, Models.DbAtVdc2.TblHpNganh tblHpNganh)
        {
            OnTblHpNganhUpdated(tblHpNganh);

            var item = context.TblHpNganhs
                              .Where(i => i.Nganh_ID == nganhId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpNganh);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpNganh;
        }

        partial void OnTblHpNgoaiNguDeleted(Models.DbAtVdc2.TblHpNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpNgoaiNgu> DeleteTblHpNgoaiNgu(string ngoaiNguId)
        {
            var item = context.TblHpNgoaiNgus
                              .Where(i => i.NgoaiNgu_ID == ngoaiNguId)
                              .FirstOrDefault();

            OnTblHpNgoaiNguDeleted(item);

            context.TblHpNgoaiNgus.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpNgoaiNguGet(Models.DbAtVdc2.TblHpNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpNgoaiNgu> GetTblHpNgoaiNguByNgoaiNguId(string ngoaiNguId)
        {
            var items = context.TblHpNgoaiNgus
                              .AsNoTracking()
                              .Where(i => i.NgoaiNgu_ID == ngoaiNguId);

            var item = items.FirstOrDefault();

            OnTblHpNgoaiNguGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpNgoaiNgu> CancelTblHpNgoaiNguChanges(Models.DbAtVdc2.TblHpNgoaiNgu item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpNgoaiNguUpdated(Models.DbAtVdc2.TblHpNgoaiNgu item);

        public async Task<Models.DbAtVdc2.TblHpNgoaiNgu> UpdateTblHpNgoaiNgu(string ngoaiNguId, Models.DbAtVdc2.TblHpNgoaiNgu tblHpNgoaiNgu)
        {
            OnTblHpNgoaiNguUpdated(tblHpNgoaiNgu);

            var item = context.TblHpNgoaiNgus
                              .Where(i => i.NgoaiNgu_ID == ngoaiNguId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpNgoaiNgu);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpNgoaiNgu;
        }

        partial void OnTblHpNhanVienDeleted(Models.DbAtVdc2.TblHpNhanVien item);

        public async Task<Models.DbAtVdc2.TblHpNhanVien> DeleteTblHpNhanVien(string nhanVienId)
        {
            var item = context.TblHpNhanViens
                              .Where(i => i.NhanVien_ID == nhanVienId)
                              .Include(i => i.TblHpChiTietLuongs)
                              .Include(i => i.TblHpChiTietNgoaiNgus)
                              .Include(i => i.TblHpChiTietGiaCanhs)
                              .Include(i => i.TblHpChiTietCongTacs)
                              .Include(i => i.TblHpChiTietChuyenMons)
                              .FirstOrDefault();

            OnTblHpNhanVienDeleted(item);

            context.TblHpNhanViens.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpNhanVienGet(Models.DbAtVdc2.TblHpNhanVien item);

        public async Task<Models.DbAtVdc2.TblHpNhanVien> GetTblHpNhanVienByNhanVienId(string nhanVienId)
        {
            var items = context.TblHpNhanViens
                              .AsNoTracking()
                              .Where(i => i.NhanVien_ID == nhanVienId);

            items = items.Include(i => i.TblHpTinhTp);

            items = items.Include(i => i.TblHpTinhTp1);

            items = items.Include(i => i.TblHpDanToc);

            items = items.Include(i => i.TblHpTonGiao);

            items = items.Include(i => i.TblHpQuocTich);

            items = items.Include(i => i.TblHpQuan);

            items = items.Include(i => i.TblHpTinhTp2);

            items = items.Include(i => i.TblHpQuan1);

            items = items.Include(i => i.TblHpTinhTp3);

            items = items.Include(i => i.TblGnDepartment);

            items = items.Include(i => i.TblHpDonViTo);

            items = items.Include(i => i.TblHpChucVu);

            items = items.Include(i => i.TblHpTrinhDoVanHoa);

            items = items.Include(i => i.TblHpNgach);

            items = items.Include(i => i.TblHpBac);

            var item = items.FirstOrDefault();

            OnTblHpNhanVienGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpNhanVien> CancelTblHpNhanVienChanges(Models.DbAtVdc2.TblHpNhanVien item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpNhanVienUpdated(Models.DbAtVdc2.TblHpNhanVien item);

        public async Task<Models.DbAtVdc2.TblHpNhanVien> UpdateTblHpNhanVien(string nhanVienId, Models.DbAtVdc2.TblHpNhanVien tblHpNhanVien)
        {
            OnTblHpNhanVienUpdated(tblHpNhanVien);

            var item = context.TblHpNhanViens
                              .Where(i => i.NhanVien_ID == nhanVienId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpNhanVien);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpNhanVien;
        }

        partial void OnTblHpPhanLoaiNvDeleted(Models.DbAtVdc2.TblHpPhanLoaiNv item);

        public async Task<Models.DbAtVdc2.TblHpPhanLoaiNv> DeleteTblHpPhanLoaiNv(string phanLoaiNvId)
        {
            var item = context.TblHpPhanLoaiNvs
                              .Where(i => i.PhanLoaiNV_ID == phanLoaiNvId)
                              .FirstOrDefault();

            OnTblHpPhanLoaiNvDeleted(item);

            context.TblHpPhanLoaiNvs.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpPhanLoaiNvGet(Models.DbAtVdc2.TblHpPhanLoaiNv item);

        public async Task<Models.DbAtVdc2.TblHpPhanLoaiNv> GetTblHpPhanLoaiNvByPhanLoaiNvId(string phanLoaiNvId)
        {
            var items = context.TblHpPhanLoaiNvs
                              .AsNoTracking()
                              .Where(i => i.PhanLoaiNV_ID == phanLoaiNvId);

            var item = items.FirstOrDefault();

            OnTblHpPhanLoaiNvGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpPhanLoaiNv> CancelTblHpPhanLoaiNvChanges(Models.DbAtVdc2.TblHpPhanLoaiNv item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpPhanLoaiNvUpdated(Models.DbAtVdc2.TblHpPhanLoaiNv item);

        public async Task<Models.DbAtVdc2.TblHpPhanLoaiNv> UpdateTblHpPhanLoaiNv(string phanLoaiNvId, Models.DbAtVdc2.TblHpPhanLoaiNv tblHpPhanLoaiNv)
        {
            OnTblHpPhanLoaiNvUpdated(tblHpPhanLoaiNv);

            var item = context.TblHpPhanLoaiNvs
                              .Where(i => i.PhanLoaiNV_ID == phanLoaiNvId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpPhanLoaiNv);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpPhanLoaiNv;
        }

        partial void OnTblHpQuanDeleted(Models.DbAtVdc2.TblHpQuan item);

        public async Task<Models.DbAtVdc2.TblHpQuan> DeleteTblHpQuan(string quanId)
        {
            var item = context.TblHpQuans
                              .Where(i => i.Quan_ID == quanId)
                              .Include(i => i.TblHpNhanViens)
                              .Include(i => i.TblHpNhanViens1)
                              .FirstOrDefault();

            OnTblHpQuanDeleted(item);

            context.TblHpQuans.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpQuanGet(Models.DbAtVdc2.TblHpQuan item);

        public async Task<Models.DbAtVdc2.TblHpQuan> GetTblHpQuanByQuanId(string quanId)
        {
            var items = context.TblHpQuans
                              .AsNoTracking()
                              .Where(i => i.Quan_ID == quanId);

            var item = items.FirstOrDefault();

            OnTblHpQuanGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpQuan> CancelTblHpQuanChanges(Models.DbAtVdc2.TblHpQuan item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpQuanUpdated(Models.DbAtVdc2.TblHpQuan item);

        public async Task<Models.DbAtVdc2.TblHpQuan> UpdateTblHpQuan(string quanId, Models.DbAtVdc2.TblHpQuan tblHpQuan)
        {
            OnTblHpQuanUpdated(tblHpQuan);

            var item = context.TblHpQuans
                              .Where(i => i.Quan_ID == quanId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpQuan);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpQuan;
        }

        partial void OnTblHpQuocTichDeleted(Models.DbAtVdc2.TblHpQuocTich item);

        public async Task<Models.DbAtVdc2.TblHpQuocTich> DeleteTblHpQuocTich(string quocTichId)
        {
            var item = context.TblHpQuocTiches
                              .Where(i => i.QuocTich_ID == quocTichId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpQuocTichDeleted(item);

            context.TblHpQuocTiches.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpQuocTichGet(Models.DbAtVdc2.TblHpQuocTich item);

        public async Task<Models.DbAtVdc2.TblHpQuocTich> GetTblHpQuocTichByQuocTichId(string quocTichId)
        {
            var items = context.TblHpQuocTiches
                              .AsNoTracking()
                              .Where(i => i.QuocTich_ID == quocTichId);

            var item = items.FirstOrDefault();

            OnTblHpQuocTichGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpQuocTich> CancelTblHpQuocTichChanges(Models.DbAtVdc2.TblHpQuocTich item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpQuocTichUpdated(Models.DbAtVdc2.TblHpQuocTich item);

        public async Task<Models.DbAtVdc2.TblHpQuocTich> UpdateTblHpQuocTich(string quocTichId, Models.DbAtVdc2.TblHpQuocTich tblHpQuocTich)
        {
            OnTblHpQuocTichUpdated(tblHpQuocTich);

            var item = context.TblHpQuocTiches
                              .Where(i => i.QuocTich_ID == quocTichId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpQuocTich);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpQuocTich;
        }

        partial void OnTblHpTinhTpDeleted(Models.DbAtVdc2.TblHpTinhTp item);

        public async Task<Models.DbAtVdc2.TblHpTinhTp> DeleteTblHpTinhTp(string tinhTpId)
        {
            var item = context.TblHpTinhTps
                              .Where(i => i.TinhTP_ID == tinhTpId)
                              .Include(i => i.TblHpNhanViens)
                              .Include(i => i.TblHpNhanViens1)
                              .Include(i => i.TblHpNhanViens2)
                              .Include(i => i.TblHpNhanViens3)
                              .FirstOrDefault();

            OnTblHpTinhTpDeleted(item);

            context.TblHpTinhTps.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpTinhTpGet(Models.DbAtVdc2.TblHpTinhTp item);

        public async Task<Models.DbAtVdc2.TblHpTinhTp> GetTblHpTinhTpByTinhTpId(string tinhTpId)
        {
            var items = context.TblHpTinhTps
                              .AsNoTracking()
                              .Where(i => i.TinhTP_ID == tinhTpId);

            var item = items.FirstOrDefault();

            OnTblHpTinhTpGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpTinhTp> CancelTblHpTinhTpChanges(Models.DbAtVdc2.TblHpTinhTp item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpTinhTpUpdated(Models.DbAtVdc2.TblHpTinhTp item);

        public async Task<Models.DbAtVdc2.TblHpTinhTp> UpdateTblHpTinhTp(string tinhTpId, Models.DbAtVdc2.TblHpTinhTp tblHpTinhTp)
        {
            OnTblHpTinhTpUpdated(tblHpTinhTp);

            var item = context.TblHpTinhTps
                              .Where(i => i.TinhTP_ID == tinhTpId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpTinhTp);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpTinhTp;
        }

        partial void OnTblHpTonGiaoDeleted(Models.DbAtVdc2.TblHpTonGiao item);

        public async Task<Models.DbAtVdc2.TblHpTonGiao> DeleteTblHpTonGiao(string tonGiaoId)
        {
            var item = context.TblHpTonGiaos
                              .Where(i => i.TonGiao_ID == tonGiaoId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpTonGiaoDeleted(item);

            context.TblHpTonGiaos.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpTonGiaoGet(Models.DbAtVdc2.TblHpTonGiao item);

        public async Task<Models.DbAtVdc2.TblHpTonGiao> GetTblHpTonGiaoByTonGiaoId(string tonGiaoId)
        {
            var items = context.TblHpTonGiaos
                              .AsNoTracking()
                              .Where(i => i.TonGiao_ID == tonGiaoId);

            var item = items.FirstOrDefault();

            OnTblHpTonGiaoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpTonGiao> CancelTblHpTonGiaoChanges(Models.DbAtVdc2.TblHpTonGiao item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpTonGiaoUpdated(Models.DbAtVdc2.TblHpTonGiao item);

        public async Task<Models.DbAtVdc2.TblHpTonGiao> UpdateTblHpTonGiao(string tonGiaoId, Models.DbAtVdc2.TblHpTonGiao tblHpTonGiao)
        {
            OnTblHpTonGiaoUpdated(tblHpTonGiao);

            var item = context.TblHpTonGiaos
                              .Where(i => i.TonGiao_ID == tonGiaoId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpTonGiao);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpTonGiao;
        }

        partial void OnTblHpTrinhDoChuyenMonDeleted(Models.DbAtVdc2.TblHpTrinhDoChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> DeleteTblHpTrinhDoChuyenMon(string trinhDoChuyenMonId)
        {
            var item = context.TblHpTrinhDoChuyenMons
                              .Where(i => i.TrinhDoChuyenMon_ID == trinhDoChuyenMonId)
                              .FirstOrDefault();

            OnTblHpTrinhDoChuyenMonDeleted(item);

            context.TblHpTrinhDoChuyenMons.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpTrinhDoChuyenMonGet(Models.DbAtVdc2.TblHpTrinhDoChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> GetTblHpTrinhDoChuyenMonByTrinhDoChuyenMonId(string trinhDoChuyenMonId)
        {
            var items = context.TblHpTrinhDoChuyenMons
                              .AsNoTracking()
                              .Where(i => i.TrinhDoChuyenMon_ID == trinhDoChuyenMonId);

            var item = items.FirstOrDefault();

            OnTblHpTrinhDoChuyenMonGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> CancelTblHpTrinhDoChuyenMonChanges(Models.DbAtVdc2.TblHpTrinhDoChuyenMon item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpTrinhDoChuyenMonUpdated(Models.DbAtVdc2.TblHpTrinhDoChuyenMon item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoChuyenMon> UpdateTblHpTrinhDoChuyenMon(string trinhDoChuyenMonId, Models.DbAtVdc2.TblHpTrinhDoChuyenMon tblHpTrinhDoChuyenMon)
        {
            OnTblHpTrinhDoChuyenMonUpdated(tblHpTrinhDoChuyenMon);

            var item = context.TblHpTrinhDoChuyenMons
                              .Where(i => i.TrinhDoChuyenMon_ID == trinhDoChuyenMonId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpTrinhDoChuyenMon);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpTrinhDoChuyenMon;
        }

        partial void OnTblHpTrinhDoVanHoaDeleted(Models.DbAtVdc2.TblHpTrinhDoVanHoa item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoVanHoa> DeleteTblHpTrinhDoVanHoa(string trinhDoVanHoaId)
        {
            var item = context.TblHpTrinhDoVanHoas
                              .Where(i => i.TrinhDoVanHoa_ID == trinhDoVanHoaId)
                              .Include(i => i.TblHpNhanViens)
                              .FirstOrDefault();

            OnTblHpTrinhDoVanHoaDeleted(item);

            context.TblHpTrinhDoVanHoas.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpTrinhDoVanHoaGet(Models.DbAtVdc2.TblHpTrinhDoVanHoa item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoVanHoa> GetTblHpTrinhDoVanHoaByTrinhDoVanHoaId(string trinhDoVanHoaId)
        {
            var items = context.TblHpTrinhDoVanHoas
                              .AsNoTracking()
                              .Where(i => i.TrinhDoVanHoa_ID == trinhDoVanHoaId);

            var item = items.FirstOrDefault();

            OnTblHpTrinhDoVanHoaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpTrinhDoVanHoa> CancelTblHpTrinhDoVanHoaChanges(Models.DbAtVdc2.TblHpTrinhDoVanHoa item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpTrinhDoVanHoaUpdated(Models.DbAtVdc2.TblHpTrinhDoVanHoa item);

        public async Task<Models.DbAtVdc2.TblHpTrinhDoVanHoa> UpdateTblHpTrinhDoVanHoa(string trinhDoVanHoaId, Models.DbAtVdc2.TblHpTrinhDoVanHoa tblHpTrinhDoVanHoa)
        {
            OnTblHpTrinhDoVanHoaUpdated(tblHpTrinhDoVanHoa);

            var item = context.TblHpTrinhDoVanHoas
                              .Where(i => i.TrinhDoVanHoa_ID == trinhDoVanHoaId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpTrinhDoVanHoa);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpTrinhDoVanHoa;
        }

        partial void OnTblHpXiNghiepDeleted(Models.DbAtVdc2.TblHpXiNghiep item);

        public async Task<Models.DbAtVdc2.TblHpXiNghiep> DeleteTblHpXiNghiep(string xiNghiepId)
        {
            var item = context.TblHpXiNghieps
                              .Where(i => i.XiNghiep_ID == xiNghiepId)
                              .FirstOrDefault();

            OnTblHpXiNghiepDeleted(item);

            context.TblHpXiNghieps.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblHpXiNghiepGet(Models.DbAtVdc2.TblHpXiNghiep item);

        public async Task<Models.DbAtVdc2.TblHpXiNghiep> GetTblHpXiNghiepByXiNghiepId(string xiNghiepId)
        {
            var items = context.TblHpXiNghieps
                              .AsNoTracking()
                              .Where(i => i.XiNghiep_ID == xiNghiepId);

            var item = items.FirstOrDefault();

            OnTblHpXiNghiepGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.DbAtVdc2.TblHpXiNghiep> CancelTblHpXiNghiepChanges(Models.DbAtVdc2.TblHpXiNghiep item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblHpXiNghiepUpdated(Models.DbAtVdc2.TblHpXiNghiep item);

        public async Task<Models.DbAtVdc2.TblHpXiNghiep> UpdateTblHpXiNghiep(string xiNghiepId, Models.DbAtVdc2.TblHpXiNghiep tblHpXiNghiep)
        {
            OnTblHpXiNghiepUpdated(tblHpXiNghiep);

            var item = context.TblHpXiNghieps
                              .Where(i => i.XiNghiep_ID == xiNghiepId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblHpXiNghiep);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblHpXiNghiep;
        }
    }
}
