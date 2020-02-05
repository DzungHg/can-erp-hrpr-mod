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
    public partial class TblHpDonViTosComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> _getTblHpDonViTosResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo> getTblHpDonViTosResult
        {
            get
            {
                return _getTblHpDonViTosResult;
            }
            set
            {
                if(!object.Equals(_getTblHpDonViTosResult, value))
                {
                    _getTblHpDonViTosResult = value;
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
            var dbAtVdc2GetTblHpDonViTosResult = await DbAtVdc2.GetTblHpDonViTos();
            getTblHpDonViTosResult = dbAtVdc2GetTblHpDonViTosResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpDonViTo>("Add Tbl Hp Don Vi To", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpDonViTo args)
        {
            var result = await DialogService.OpenAsync<EditTblHpDonViTo>("Edit Tbl Hp Don Vi To", new Dictionary<string, object>() { {"DonViTo_ID", args.DonViTo_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpDonViToResult = await DbAtVdc2.DeleteTblHpDonViTo($"{data.DonViTo_ID}");
                if (dbAtVdc2DeleteTblHpDonViToResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpDonViToException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpDonViTo");
            }
        }
    }
}
