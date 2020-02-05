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
    public partial class TblHpChucVusComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> _getTblHpChucVusResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChucVu> getTblHpChucVusResult
        {
            get
            {
                return _getTblHpChucVusResult;
            }
            set
            {
                if(!object.Equals(_getTblHpChucVusResult, value))
                {
                    _getTblHpChucVusResult = value;
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
            var dbAtVdc2GetTblHpChucVusResult = await DbAtVdc2.GetTblHpChucVus();
            getTblHpChucVusResult = dbAtVdc2GetTblHpChucVusResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpChucVu>("Add Tbl Hp Chuc Vu", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpChucVu args)
        {
            var result = await DialogService.OpenAsync<EditTblHpChucVu>("Edit Tbl Hp Chuc Vu", new Dictionary<string, object>() { {"ChucVu_ID", args.ChucVu_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpChucVuResult = await DbAtVdc2.DeleteTblHpChucVu($"{data.ChucVu_ID}");
                if (dbAtVdc2DeleteTblHpChucVuResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpChucVuException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpChucVu");
            }
        }
    }
}
