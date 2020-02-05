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
    public partial class TblHpTonGiaosComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> _getTblHpTonGiaosResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao> getTblHpTonGiaosResult
        {
            get
            {
                return _getTblHpTonGiaosResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTonGiaosResult, value))
                {
                    _getTblHpTonGiaosResult = value;
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
            var dbAtVdc2GetTblHpTonGiaosResult = await DbAtVdc2.GetTblHpTonGiaos();
            getTblHpTonGiaosResult = dbAtVdc2GetTblHpTonGiaosResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpTonGiao>("Add Tbl Hp Ton Giao", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpTonGiao args)
        {
            var result = await DialogService.OpenAsync<EditTblHpTonGiao>("Edit Tbl Hp Ton Giao", new Dictionary<string, object>() { {"TonGiao_ID", args.TonGiao_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpTonGiaoResult = await DbAtVdc2.DeleteTblHpTonGiao($"{data.TonGiao_ID}");
                if (dbAtVdc2DeleteTblHpTonGiaoResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpTonGiaoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpTonGiao");
            }
        }
    }
}
