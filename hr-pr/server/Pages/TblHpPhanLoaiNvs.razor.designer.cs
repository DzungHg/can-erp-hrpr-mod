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
    public partial class TblHpPhanLoaiNvsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv> _getTblHpPhanLoaiNvsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv> getTblHpPhanLoaiNvsResult
        {
            get
            {
                return _getTblHpPhanLoaiNvsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpPhanLoaiNvsResult, value))
                {
                    _getTblHpPhanLoaiNvsResult = value;
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
            var dbAtVdc2GetTblHpPhanLoaiNvsResult = await DbAtVdc2.GetTblHpPhanLoaiNvs();
            getTblHpPhanLoaiNvsResult = dbAtVdc2GetTblHpPhanLoaiNvsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpPhanLoaiNv>("Add Tbl Hp Phan Loai Nv", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv args)
        {
            var result = await DialogService.OpenAsync<EditTblHpPhanLoaiNv>("Edit Tbl Hp Phan Loai Nv", new Dictionary<string, object>() { {"PhanLoaiNV_ID", args.PhanLoaiNV_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpPhanLoaiNvResult = await DbAtVdc2.DeleteTblHpPhanLoaiNv($"{data.PhanLoaiNV_ID}");
                if (dbAtVdc2DeleteTblHpPhanLoaiNvResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpPhanLoaiNvException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpPhanLoaiNv");
            }
        }
    }
}
