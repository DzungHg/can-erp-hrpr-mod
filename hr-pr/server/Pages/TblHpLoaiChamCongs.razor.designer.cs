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
    public partial class TblHpLoaiChamCongsComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong> _getTblHpLoaiChamCongsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong> getTblHpLoaiChamCongsResult
        {
            get
            {
                return _getTblHpLoaiChamCongsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpLoaiChamCongsResult, value))
                {
                    _getTblHpLoaiChamCongsResult = value;
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
            var dbAtVdc2GetTblHpLoaiChamCongsResult = await DbAtVdc2.GetTblHpLoaiChamCongs();
            getTblHpLoaiChamCongsResult = dbAtVdc2GetTblHpLoaiChamCongsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpLoaiChamCong>("Add Tbl Hp Loai Cham Cong", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong args)
        {
            var result = await DialogService.OpenAsync<EditTblHpLoaiChamCong>("Edit Tbl Hp Loai Cham Cong", new Dictionary<string, object>() { {"LoaiChamCong_ID", args.LoaiChamCong_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpLoaiChamCongResult = await DbAtVdc2.DeleteTblHpLoaiChamCong($"{data.LoaiChamCong_ID}");
                if (dbAtVdc2DeleteTblHpLoaiChamCongResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpLoaiChamCongException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpLoaiChamCong");
            }
        }
    }
}
