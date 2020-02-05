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
    public partial class TblHpNganhsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpNganh> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNganh> _getTblHpNganhsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNganh> getTblHpNganhsResult
        {
            get
            {
                return _getTblHpNganhsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNganhsResult, value))
                {
                    _getTblHpNganhsResult = value;
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
            var dbAtVdc2GetTblHpNganhsResult = await DbAtVdc2.GetTblHpNganhs();
            getTblHpNganhsResult = dbAtVdc2GetTblHpNganhsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpNganh>("Add Tbl Hp Nganh", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpNganh args)
        {
            var result = await DialogService.OpenAsync<EditTblHpNganh>("Edit Tbl Hp Nganh", new Dictionary<string, object>() { {"Nganh_ID", args.Nganh_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpNganhResult = await DbAtVdc2.DeleteTblHpNganh($"{data.Nganh_ID}");
                if (dbAtVdc2DeleteTblHpNganhResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpNganhException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpNganh");
            }
        }
    }
}
