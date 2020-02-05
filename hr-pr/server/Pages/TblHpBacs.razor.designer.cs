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
    public partial class TblHpBacsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpBac> grid0;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var dbAtVdc2GetTblHpBacsResult = await DbAtVdc2.GetTblHpBacs();
            getTblHpBacsResult = dbAtVdc2GetTblHpBacsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpBac>("Add Tbl Hp Bac", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpBac args)
        {
            var result = await DialogService.OpenAsync<EditTblHpBac>("Edit Tbl Hp Bac", new Dictionary<string, object>() { {"Bac_ID", args.Bac_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpBacResult = await DbAtVdc2.DeleteTblHpBac($"{data.Bac_ID}");
                if (dbAtVdc2DeleteTblHpBacResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpBacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpBac");
            }
        }
    }
}
