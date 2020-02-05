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
    public partial class TblHpChiTietGiaCanhsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh> _getTblHpChiTietGiaCanhsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh> getTblHpChiTietGiaCanhsResult
        {
            get
            {
                return _getTblHpChiTietGiaCanhsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChiTietGiaCanhsResult, value))
                {
                    _getTblHpChiTietGiaCanhsResult = value;
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
            var dbAtVdc2GetTblHpChiTietGiaCanhsResult = await DbAtVdc2.GetTblHpChiTietGiaCanhs();
            getTblHpChiTietGiaCanhsResult = dbAtVdc2GetTblHpChiTietGiaCanhsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChiTietGiaCanh>("Add Tbl Hp Chi Tiet Gia Canh", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChiTietGiaCanh>("Edit Tbl Hp Chi Tiet Gia Canh", new Dictionary<string, object>() { {"ChiTietGiaCanh_SEQ", args.ChiTietGiaCanh_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChiTietGiaCanhResult = await DbAtVdc2.DeleteTblHpChiTietGiaCanh(data.ChiTietGiaCanh_SEQ);
                if (dbAtVdc2DeleteTblHpChiTietGiaCanhResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChiTietGiaCanhException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChiTietGiaCanh");
            }
        }
    }
}
