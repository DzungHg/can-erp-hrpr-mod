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
    public partial class TblHpChiTietCongTacsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac> _getTblHpChiTietCongTacsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac> getTblHpChiTietCongTacsResult
        {
            get
            {
                return _getTblHpChiTietCongTacsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChiTietCongTacsResult, value))
                {
                    _getTblHpChiTietCongTacsResult = value;
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
            var dbAtVdc2GetTblHpChiTietCongTacsResult = await DbAtVdc2.GetTblHpChiTietCongTacs();
            getTblHpChiTietCongTacsResult = dbAtVdc2GetTblHpChiTietCongTacsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChiTietCongTac>("Add Tbl Hp Chi Tiet Cong Tac", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChiTietCongTac>("Edit Tbl Hp Chi Tiet Cong Tac", new Dictionary<string, object>() { {"ChiTietCongTac_SEQ", args.ChiTietCongTac_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChiTietCongTacResult = await DbAtVdc2.DeleteTblHpChiTietCongTac(data.ChiTietCongTac_SEQ);
                if (dbAtVdc2DeleteTblHpChiTietCongTacResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChiTietCongTacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChiTietCongTac");
            }
        }
    }
}
