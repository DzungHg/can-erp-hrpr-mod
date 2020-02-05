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
    public partial class TblHpNgoaiNgusComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu> _getTblHpNgoaiNgusResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu> getTblHpNgoaiNgusResult
        {
            get
            {
                return _getTblHpNgoaiNgusResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNgoaiNgusResult, value))
                {
                    _getTblHpNgoaiNgusResult = value;
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
            var dbAtVdc2GetTblHpNgoaiNgusResult = await DbAtVdc2.GetTblHpNgoaiNgus();
            getTblHpNgoaiNgusResult = dbAtVdc2GetTblHpNgoaiNgusResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpNgoaiNgu>("Add Tbl Hp Ngoai Ngu", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu args)
        {
            var result = await DialogService.OpenAsync<EditTblHpNgoaiNgu>("Edit Tbl Hp Ngoai Ngu", new Dictionary<string, object>() { {"NgoaiNgu_ID", args.NgoaiNgu_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpNgoaiNguResult = await DbAtVdc2.DeleteTblHpNgoaiNgu($"{data.NgoaiNgu_ID}");
                if (dbAtVdc2DeleteTblHpNgoaiNguResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpNgoaiNguException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpNgoaiNgu");
            }
        }
    }
}
