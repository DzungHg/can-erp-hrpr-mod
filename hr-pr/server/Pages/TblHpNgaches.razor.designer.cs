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
    public partial class TblHpNgachesComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> _getTblHpNgachesResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> getTblHpNgachesResult
        {
            get
            {
                return _getTblHpNgachesResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNgachesResult, value))
                {
                    _getTblHpNgachesResult = value;
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
            var dbAtVdc2GetTblHpNgachesResult = await DbAtVdc2.GetTblHpNgaches();
            getTblHpNgachesResult = dbAtVdc2GetTblHpNgachesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpNgach>("Add Tbl Hp Ngach", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpNgach args)
        {
            var result = await DialogService.OpenAsync<EditTblHpNgach>("Edit Tbl Hp Ngach", new Dictionary<string, object>() { {"Ngach_ID", args.Ngach_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpNgachResult = await DbAtVdc2.DeleteTblHpNgach($"{data.Ngach_ID}");
                if (dbAtVdc2DeleteTblHpNgachResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpNgachException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpNgach");
            }
        }
    }
}
