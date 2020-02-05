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
    public partial class TblHpChiTietChuyenMonsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon> _getTblHpChiTietChuyenMonsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon> getTblHpChiTietChuyenMonsResult
        {
            get
            {
                return _getTblHpChiTietChuyenMonsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChiTietChuyenMonsResult, value))
                {
                    _getTblHpChiTietChuyenMonsResult = value;
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
            var dbAtVdc2GetTblHpChiTietChuyenMonsResult = await DbAtVdc2.GetTblHpChiTietChuyenMons();
            getTblHpChiTietChuyenMonsResult = dbAtVdc2GetTblHpChiTietChuyenMonsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChiTietChuyenMon>("Add Tbl Hp Chi Tiet Chuyen Mon", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietChuyenMon args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChiTietChuyenMon>("Edit Tbl Hp Chi Tiet Chuyen Mon", new Dictionary<string, object>() { {"ChiTietChuyenMon_SEQ", args.ChiTietChuyenMon_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChiTietChuyenMonResult = await DbAtVdc2.DeleteTblHpChiTietChuyenMon(data.ChiTietChuyenMon_SEQ);
                if (dbAtVdc2DeleteTblHpChiTietChuyenMonResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChiTietChuyenMonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChiTietChuyenMon");
            }
        }
    }
}
