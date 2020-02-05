using Microsoft.AspNetCore.Mvc;
using CanErpHrPr.Data;

namespace CanErpHrPr
{
    public partial class ExportDbAtVdc2Controller : ExportController
    {
        private readonly DbAtVdc2Context context;

        public ExportDbAtVdc2Controller(DbAtVdc2Context context)
        {
            this.context = context;
        }

        [HttpGet("/export/DbAtVdc2/tblgndepartments/csv")]
        public FileStreamResult ExportTblGnDepartmentsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblGnDepartments, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblgndepartments/excel")]
        public FileStreamResult ExportTblGnDepartmentsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblGnDepartments, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpbacs/csv")]
        public FileStreamResult ExportTblHpBacsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpBacs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpbacs/excel")]
        public FileStreamResult ExportTblHpBacsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpBacs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietchuyenmons/csv")]
        public FileStreamResult ExportTblHpChiTietChuyenMonsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChiTietChuyenMons, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietchuyenmons/excel")]
        public FileStreamResult ExportTblHpChiTietChuyenMonsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChiTietChuyenMons, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietcongtacs/csv")]
        public FileStreamResult ExportTblHpChiTietCongTacsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChiTietCongTacs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietcongtacs/excel")]
        public FileStreamResult ExportTblHpChiTietCongTacsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChiTietCongTacs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietgiacanhs/csv")]
        public FileStreamResult ExportTblHpChiTietGiaCanhsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChiTietGiaCanhs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietgiacanhs/excel")]
        public FileStreamResult ExportTblHpChiTietGiaCanhsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChiTietGiaCanhs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietluongs/csv")]
        public FileStreamResult ExportTblHpChiTietLuongsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChiTietLuongs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietluongs/excel")]
        public FileStreamResult ExportTblHpChiTietLuongsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChiTietLuongs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietngoaingus/csv")]
        public FileStreamResult ExportTblHpChiTietNgoaiNgusToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChiTietNgoaiNgus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchitietngoaingus/excel")]
        public FileStreamResult ExportTblHpChiTietNgoaiNgusToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChiTietNgoaiNgus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchucvus/csv")]
        public FileStreamResult ExportTblHpChucVusToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpChucVus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpchucvus/excel")]
        public FileStreamResult ExportTblHpChucVusToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpChucVus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpdantocs/csv")]
        public FileStreamResult ExportTblHpDanTocsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpDanTocs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpdantocs/excel")]
        public FileStreamResult ExportTblHpDanTocsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpDanTocs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpdonvitos/csv")]
        public FileStreamResult ExportTblHpDonViTosToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpDonViTos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpdonvitos/excel")]
        public FileStreamResult ExportTblHpDonViTosToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpDonViTos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhphedaotaos/csv")]
        public FileStreamResult ExportTblHpHeDaoTaosToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpHeDaoTaos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhphedaotaos/excel")]
        public FileStreamResult ExportTblHpHeDaoTaosToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpHeDaoTaos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhploaichamcongs/csv")]
        public FileStreamResult ExportTblHpLoaiChamCongsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpLoaiChamCongs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhploaichamcongs/excel")]
        public FileStreamResult ExportTblHpLoaiChamCongsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpLoaiChamCongs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpngaches/csv")]
        public FileStreamResult ExportTblHpNgachesToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpNgaches, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpngaches/excel")]
        public FileStreamResult ExportTblHpNgachesToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpNgaches, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpnganhs/csv")]
        public FileStreamResult ExportTblHpNganhsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpNganhs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpnganhs/excel")]
        public FileStreamResult ExportTblHpNganhsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpNganhs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpngoaingus/csv")]
        public FileStreamResult ExportTblHpNgoaiNgusToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpNgoaiNgus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpngoaingus/excel")]
        public FileStreamResult ExportTblHpNgoaiNgusToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpNgoaiNgus, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpnhanviens/csv")]
        public FileStreamResult ExportTblHpNhanViensToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpNhanViens, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpnhanviens/excel")]
        public FileStreamResult ExportTblHpNhanViensToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpNhanViens, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpphanloainvs/csv")]
        public FileStreamResult ExportTblHpPhanLoaiNvsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpPhanLoaiNvs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpphanloainvs/excel")]
        public FileStreamResult ExportTblHpPhanLoaiNvsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpPhanLoaiNvs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpquans/csv")]
        public FileStreamResult ExportTblHpQuansToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpQuans, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpquans/excel")]
        public FileStreamResult ExportTblHpQuansToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpQuans, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpquoctiches/csv")]
        public FileStreamResult ExportTblHpQuocTichesToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpQuocTiches, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpquoctiches/excel")]
        public FileStreamResult ExportTblHpQuocTichesToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpQuocTiches, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptinhtps/csv")]
        public FileStreamResult ExportTblHpTinhTpsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpTinhTps, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptinhtps/excel")]
        public FileStreamResult ExportTblHpTinhTpsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpTinhTps, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptongiaos/csv")]
        public FileStreamResult ExportTblHpTonGiaosToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpTonGiaos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptongiaos/excel")]
        public FileStreamResult ExportTblHpTonGiaosToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpTonGiaos, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptrinhdochuyenmons/csv")]
        public FileStreamResult ExportTblHpTrinhDoChuyenMonsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpTrinhDoChuyenMons, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptrinhdochuyenmons/excel")]
        public FileStreamResult ExportTblHpTrinhDoChuyenMonsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpTrinhDoChuyenMons, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptrinhdovanhoas/csv")]
        public FileStreamResult ExportTblHpTrinhDoVanHoasToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpTrinhDoVanHoas, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhptrinhdovanhoas/excel")]
        public FileStreamResult ExportTblHpTrinhDoVanHoasToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpTrinhDoVanHoas, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpxinghieps/csv")]
        public FileStreamResult ExportTblHpXiNghiepsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblHpXiNghieps, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/tblhpxinghieps/excel")]
        public FileStreamResult ExportTblHpXiNghiepsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblHpXiNghieps, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/vwhrlylichnvs/csv")]
        public FileStreamResult ExportVwHrLyLichNvsToCSV()
        {
            return ToCSV(ApplyQuery(context.VwHrLyLichNvs, Request.Query));
        }

        [HttpGet("/export/DbAtVdc2/vwhrlylichnvs/excel")]
        public FileStreamResult ExportVwHrLyLichNvsToExcel()
        {
            return ToExcel(ApplyQuery(context.VwHrLyLichNvs, Request.Query));
        }
    }
}
