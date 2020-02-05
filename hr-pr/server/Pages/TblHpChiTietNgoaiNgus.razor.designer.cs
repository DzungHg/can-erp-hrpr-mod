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
    public partial class TblHpChiTietNgoaiNgusComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu> _getTblHpChiTietNgoaiNgusResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu> getTblHpChiTietNgoaiNgusResult
        {
            get
            {
                return _getTblHpChiTietNgoaiNgusResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChiTietNgoaiNgusResult, value))
                {
                    _getTblHpChiTietNgoaiNgusResult = value;
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
            var dbAtVdc2GetTblHpChiTietNgoaiNgusResult = await DbAtVdc2.GetTblHpChiTietNgoaiNgus();
            getTblHpChiTietNgoaiNgusResult = dbAtVdc2GetTblHpChiTietNgoaiNgusResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChiTietNgoaiNgu>("Add Tbl Hp Chi Tiet Ngoai Ngu", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChiTietNgoaiNgu>("Edit Tbl Hp Chi Tiet Ngoai Ngu", new Dictionary<string, object>() { {"ChiTietNgoaiNgu_SEQ", args.ChiTietNgoaiNgu_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChiTietNgoaiNguResult = await DbAtVdc2.DeleteTblHpChiTietNgoaiNgu(data.ChiTietNgoaiNgu_SEQ);
                if (dbAtVdc2DeleteTblHpChiTietNgoaiNguResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChiTietNgoaiNguException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChiTietNgoaiNgu");
            }
        }
    }
}
