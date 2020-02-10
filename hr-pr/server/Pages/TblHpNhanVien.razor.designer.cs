using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CanErpHrPr.Models.DbAtVdc2;
using Microsoft.EntityFrameworkCore;

namespace CanErpHrPr.Pages
{
    public partial class TblHpNhanVienComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected DbAtVdc2Service DbAtVdc2 { get; set; }

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> grid0;

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(!object.Equals(_canEdit, value))
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTinhTp> _getTblHpTinhTpsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTinhTp> getTblHpTinhTpsResult
        {
            get
            {
                return _getTblHpTinhTpsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTinhTpsResult, value))
                {
                    _getTblHpTinhTpsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> _getTblHpDanTocsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> getTblHpDanTocsResult
        {
            get
            {
                return _getTblHpDanTocsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpDanTocsResult, value))
                {
                    _getTblHpDanTocsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> _getTblHpTonGiaosResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> getTblHpTonGiaosResult
        {
            get
            {
                return _getTblHpTonGiaosResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTonGiaosResult, value))
                {
                    _getTblHpTonGiaosResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich> _getTblHpQuocTichesResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich> getTblHpQuocTichesResult
        {
            get
            {
                return _getTblHpQuocTichesResult;
            }
            set
            {
                if(!object.Equals(_getTblHpQuocTichesResult, value))
                {
                    _getTblHpQuocTichesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> _getTblHpQuansResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> getTblHpQuansResult
        {
            get
            {
                return _getTblHpQuansResult;
            }
            set
            {
                if(!object.Equals(_getTblHpQuansResult, value))
                {
                    _getTblHpQuansResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment> _getTblGnDepartmentsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment> getTblGnDepartmentsResult
        {
            get
            {
                return _getTblGnDepartmentsResult;
            }
            set
            {
                if(!object.Equals(_getTblGnDepartmentsResult, value))
                {
                    _getTblGnDepartmentsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> _getTblHpDonViTosResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> getTblHpDonViTosResult
        {
            get
            {
                return _getTblHpDonViTosResult;
            }
            set
            {
                if(!object.Equals(_getTblHpDonViTosResult, value))
                {
                    _getTblHpDonViTosResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> _getTblHpChucVusResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> getTblHpChucVusResult
        {
            get
            {
                return _getTblHpChucVusResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChucVusResult, value))
                {
                    _getTblHpChucVusResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> _getTblHpTrinhDoVanHoasResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> getTblHpTrinhDoVanHoasResult
        {
            get
            {
                return _getTblHpTrinhDoVanHoasResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTrinhDoVanHoasResult, value))
                {
                    _getTblHpTrinhDoVanHoasResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> _getTblHpNgachesResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> getTblHpNgachesResult
        {
            get
            {
                return _getTblHpNgachesResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNgachesResult, value))
                {
                    _getTblHpNgachesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpBac> _getTblHpBacsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpBac> getTblHpBacsResult
        {
            get
            {
                return _getTblHpBacsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpBacsResult, value))
                {
                    _getTblHpBacsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> _getTblHpNhanViensResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> getTblHpNhanViensResult
        {
            get
            {
                return _getTblHpNhanViensResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNhanViensResult, value))
                {
                    _getTblHpNhanViensResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien _tblhpnhanvien;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien tblhpnhanvien
        {
            get
            {
                return _tblhpnhanvien;
            }
            set
            {
                if(!object.Equals(_tblhpnhanvien, value))
                {
                    _tblhpnhanvien = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        bool _isEdit;
        protected bool isEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                if(!object.Equals(_isEdit, value))
                {
                    _isEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            canEdit = true;

            var dbAtVdc2GetTblHpTinhTpsResult = await DbAtVdc2.GetTblHpTinhTps();
            getTblHpTinhTpsResult = dbAtVdc2GetTblHpTinhTpsResult;

            var dbAtVdc2GetTblHpDanTocsResult = await DbAtVdc2.GetTblHpDanTocs();
            getTblHpDanTocsResult = dbAtVdc2GetTblHpDanTocsResult;

            var dbAtVdc2GetTblHpTonGiaosResult = await DbAtVdc2.GetTblHpTonGiaos();
            getTblHpTonGiaosResult = dbAtVdc2GetTblHpTonGiaosResult;

            var dbAtVdc2GetTblHpQuocTichesResult = await DbAtVdc2.GetTblHpQuocTiches();
            getTblHpQuocTichesResult = dbAtVdc2GetTblHpQuocTichesResult;

            var dbAtVdc2GetTblHpQuansResult = await DbAtVdc2.GetTblHpQuans();
            getTblHpQuansResult = dbAtVdc2GetTblHpQuansResult;

            var dbAtVdc2GetTblGnDepartmentsResult = await DbAtVdc2.GetTblGnDepartments();
            getTblGnDepartmentsResult = dbAtVdc2GetTblGnDepartmentsResult;

            var dbAtVdc2GetTblHpDonViTosResult = await DbAtVdc2.GetTblHpDonViTos();
            getTblHpDonViTosResult = dbAtVdc2GetTblHpDonViTosResult;

            var dbAtVdc2GetTblHpChucVusResult = await DbAtVdc2.GetTblHpChucVus();
            getTblHpChucVusResult = dbAtVdc2GetTblHpChucVusResult;

            var dbAtVdc2GetTblHpTrinhDoVanHoasResult = await DbAtVdc2.GetTblHpTrinhDoVanHoas();
            getTblHpTrinhDoVanHoasResult = dbAtVdc2GetTblHpTrinhDoVanHoasResult;

            var dbAtVdc2GetTblHpNgachesResult = await DbAtVdc2.GetTblHpNgaches();
            getTblHpNgachesResult = dbAtVdc2GetTblHpNgachesResult;

            var dbAtVdc2GetTblHpBacsResult = await DbAtVdc2.GetTblHpBacs();
            getTblHpBacsResult = dbAtVdc2GetTblHpBacsResult;

            var dbAtVdc2GetTblHpNhanViensResult = await DbAtVdc2.GetTblHpNhanViens();
            getTblHpNhanViensResult = dbAtVdc2GetTblHpNhanViensResult;

            tblhpnhanvien = dbAtVdc2GetTblHpNhanViensResult.FirstOrDefault();

            isEdit = true;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            tblhpnhanvien = new CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien();

            isEdit = false;
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien args)
        {
            isEdit = true;

            tblhpnhanvien = args;
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpNhanVienResult = await DbAtVdc2.DeleteTblHpNhanVien($"{data.NhanVien_ID}");
                if (dbAtVdc2DeleteTblHpNhanVienResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpNhanVienException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpNhanVien");
            }
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien args)
        {
            try
            {
                if (isEdit)
                {
                    var dbAtVdc2UpdateTblHpNhanVienResult = await DbAtVdc2.UpdateTblHpNhanVien($"{tblhpnhanvien.NhanVien_ID}", tblhpnhanvien);
                    NotificationService.Notify(NotificationSeverity.Success, $"Success", $"TblHpNhanVien updated!");


                }
            }
            catch (Exception dbAtVdc2UpdateTblHpNhanVienException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpNhanVien");
            }

            try
            {
                if (!this.isEdit)
                {
                    var dbAtVdc2CreateTblHpNhanVienResult = await DbAtVdc2.CreateTblHpNhanVien(args);
                tblhpnhanvien = new CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien();

                    NotificationService.Notify(NotificationSeverity.Success, $"Success", $"TblHpNhanVien created!");
                }
            }
            catch (Exception dbAtVdc2CreateTblHpNhanVienException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpNhanVien!");
            }
        }
    }
}
