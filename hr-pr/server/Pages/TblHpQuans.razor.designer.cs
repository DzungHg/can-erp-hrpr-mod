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
    public partial class TblHpQuansComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> _getTblHpQuansResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpQuan> getTblHpQuansResult
        {
            get
            {
                return _getTblHpQuansResult;
            }
            set
            {
                if(!object.Equals(_getTblHpQuansResult, value))
                {
                    _getTblHpQuansResult = value;
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
            var dbAtVdc2GetTblHpQuansResult = await DbAtVdc2.GetTblHpQuans();
            getTblHpQuansResult = dbAtVdc2GetTblHpQuansResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpQuan>("Add Tbl Hp Quan", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpQuan args)
        {
            var result = await DialogService.OpenAsync<EditTblHpQuan>("Edit Tbl Hp Quan", new Dictionary<string, object>() { {"Quan_ID", args.Quan_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpQuanResult = await DbAtVdc2.DeleteTblHpQuan($"{data.Quan_ID}");
                if (dbAtVdc2DeleteTblHpQuanResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpQuanException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpQuan");
            }
        }
    }
}
