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
    public partial class TblHpDanTocsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> _getTblHpDanTocsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpDanToc> getTblHpDanTocsResult
        {
            get
            {
                return _getTblHpDanTocsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpDanTocsResult, value))
                {
                    _getTblHpDanTocsResult = value;
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
            var dbAtVdc2GetTblHpDanTocsResult = await DbAtVdc2.GetTblHpDanTocs();
            getTblHpDanTocsResult = dbAtVdc2GetTblHpDanTocsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpDanToc>("Add Tbl Hp Dan Toc", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpDanToc args)
        {
            var result = await DialogService.OpenAsync<EditTblHpDanToc>("Edit Tbl Hp Dan Toc", new Dictionary<string, object>() { {"DanToc_ID", args.DanToc_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpDanTocResult = await DbAtVdc2.DeleteTblHpDanToc($"{data.DanToc_ID}");
                if (dbAtVdc2DeleteTblHpDanTocResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpDanTocException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpDanToc");
            }
        }
    }
}
