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
    public partial class TblHpQuocTichesComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich> grid0;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var dbAtVdc2GetTblHpQuocTichesResult = await DbAtVdc2.GetTblHpQuocTiches();
            getTblHpQuocTichesResult = dbAtVdc2GetTblHpQuocTichesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpQuocTich>("Add Tbl Hp Quoc Tich", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich args)
        {
            var result = await DialogService.OpenAsync<EditTblHpQuocTich>("Edit Tbl Hp Quoc Tich", new Dictionary<string, object>() { {"QuocTich_ID", args.QuocTich_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpQuocTichResult = await DbAtVdc2.DeleteTblHpQuocTich($"{data.QuocTich_ID}");
                if (dbAtVdc2DeleteTblHpQuocTichResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpQuocTichException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpQuocTich");
            }
        }
    }
}
