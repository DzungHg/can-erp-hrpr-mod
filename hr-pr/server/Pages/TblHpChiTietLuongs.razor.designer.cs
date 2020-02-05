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
    public partial class TblHpChiTietLuongsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong> _getTblHpChiTietLuongsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong> getTblHpChiTietLuongsResult
        {
            get
            {
                return _getTblHpChiTietLuongsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChiTietLuongsResult, value))
                {
                    _getTblHpChiTietLuongsResult = value;
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
            var dbAtVdc2GetTblHpChiTietLuongsResult = await DbAtVdc2.GetTblHpChiTietLuongs();
            getTblHpChiTietLuongsResult = dbAtVdc2GetTblHpChiTietLuongsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChiTietLuong>("Add Tbl Hp Chi Tiet Luong", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChiTietLuong>("Edit Tbl Hp Chi Tiet Luong", new Dictionary<string, object>() { {"ChiTietLuong_SEQ", args.ChiTietLuong_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChiTietLuongResult = await DbAtVdc2.DeleteTblHpChiTietLuong(data.ChiTietLuong_SEQ);
                if (dbAtVdc2DeleteTblHpChiTietLuongResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChiTietLuongException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChiTietLuong");
            }
        }
    }
}
