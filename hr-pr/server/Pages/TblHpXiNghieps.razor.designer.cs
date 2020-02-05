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
    public partial class TblHpXiNghiepsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep> _getTblHpXiNghiepsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep> getTblHpXiNghiepsResult
        {
            get
            {
                return _getTblHpXiNghiepsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpXiNghiepsResult, value))
                {
                    _getTblHpXiNghiepsResult = value;
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
            var dbAtVdc2GetTblHpXiNghiepsResult = await DbAtVdc2.GetTblHpXiNghieps();
            getTblHpXiNghiepsResult = dbAtVdc2GetTblHpXiNghiepsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpXiNghiep>("Add Tbl Hp Xi Nghiep", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep args)
        {
            var result = await DialogService.OpenAsync<EditTblHpXiNghiep>("Edit Tbl Hp Xi Nghiep", new Dictionary<string, object>() { {"XiNghiep_ID", args.XiNghiep_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpXiNghiepResult = await DbAtVdc2.DeleteTblHpXiNghiep($"{data.XiNghiep_ID}");
                if (dbAtVdc2DeleteTblHpXiNghiepResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpXiNghiepException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpXiNghiep");
            }
        }
    }
}
