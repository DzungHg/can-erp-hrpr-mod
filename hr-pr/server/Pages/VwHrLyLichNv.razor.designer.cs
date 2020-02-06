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
    public partial class VwHrLyLichNvComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv> _getVwHrLyLichNvsResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv> getVwHrLyLichNvsResult
        {
            get
            {
                return _getVwHrLyLichNvsResult;
            }
            set
            {
                if(!object.Equals(_getVwHrLyLichNvsResult, value))
                {
                    _getVwHrLyLichNvsResult = value;
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
            var dbAtVdc2GetVwHrLyLichNvsResult = await DbAtVdc2.GetVwHrLyLichNvs();
            getVwHrLyLichNvsResult = dbAtVdc2GetVwHrLyLichNvsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddVwHpNhanVienLLich>("Add Vw Hp Nhan Vien LLich", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv args)
        {
            var result = await DialogService.OpenAsync<EditVwHpNhanVienLLich>("Edit Vw Hp Nhan Vien LLich", new Dictionary<string, object>() { {"NhanVien_ID ", args.NhanVien_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }
    }
}
