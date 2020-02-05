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
    public partial class TblHpTrinhDoChuyenMonsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon> _getTblHpTrinhDoChuyenMonsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon> getTblHpTrinhDoChuyenMonsResult
        {
            get
            {
                return _getTblHpTrinhDoChuyenMonsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTrinhDoChuyenMonsResult, value))
                {
                    _getTblHpTrinhDoChuyenMonsResult = value;
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
            var dbAtVdc2GetTblHpTrinhDoChuyenMonsResult = await DbAtVdc2.GetTblHpTrinhDoChuyenMons();
            getTblHpTrinhDoChuyenMonsResult = dbAtVdc2GetTblHpTrinhDoChuyenMonsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpTrinhDoChuyenMon>("Add Tbl Hp Trinh Do Chuyen Mon", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon args)
        {
            var result = await DialogService.OpenAsync<EditTblHpTrinhDoChuyenMon>("Edit Tbl Hp Trinh Do Chuyen Mon", new Dictionary<string, object>() { {"TrinhDoChuyenMon_ID", args.TrinhDoChuyenMon_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpTrinhDoChuyenMonResult = await DbAtVdc2.DeleteTblHpTrinhDoChuyenMon($"{data.TrinhDoChuyenMon_ID}");
                if (dbAtVdc2DeleteTblHpTrinhDoChuyenMonResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpTrinhDoChuyenMonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpTrinhDoChuyenMon");
            }
        }
    }
}
