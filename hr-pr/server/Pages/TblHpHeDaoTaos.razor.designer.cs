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
    public partial class TblHpHeDaoTaosComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao> _getTblHpHeDaoTaosResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao> getTblHpHeDaoTaosResult
        {
            get
            {
                return _getTblHpHeDaoTaosResult;
            }
            set
            {
                if(!object.Equals(_getTblHpHeDaoTaosResult, value))
                {
                    _getTblHpHeDaoTaosResult = value;
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
            var dbAtVdc2GetTblHpHeDaoTaosResult = await DbAtVdc2.GetTblHpHeDaoTaos();
            getTblHpHeDaoTaosResult = dbAtVdc2GetTblHpHeDaoTaosResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpHeDaoTao>("Add Tbl Hp He Dao Tao", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao args)
        {
            var result = await DialogService.OpenAsync<EditTblHpHeDaoTao>("Edit Tbl Hp He Dao Tao", new Dictionary<string, object>() { {"HeDaoTao_ID", args.HeDaoTao_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpHeDaoTaoResult = await DbAtVdc2.DeleteTblHpHeDaoTao($"{data.HeDaoTao_ID}");
                if (dbAtVdc2DeleteTblHpHeDaoTaoResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpHeDaoTaoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpHeDaoTao");
            }
        }
    }
}
