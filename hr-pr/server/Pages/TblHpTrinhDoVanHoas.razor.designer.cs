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
    public partial class TblHpTrinhDoVanHoasComponent : ComponentBase
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

        protected RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> grid0;

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> _getTblHpTrinhDoVanHoasResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa> getTblHpTrinhDoVanHoasResult
        {
            get
            {
                return _getTblHpTrinhDoVanHoasResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTrinhDoVanHoasResult, value))
                {
                    _getTblHpTrinhDoVanHoasResult = value;
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
            var dbAtVdc2GetTblHpTrinhDoVanHoasResult = await DbAtVdc2.GetTblHpTrinhDoVanHoas();
            getTblHpTrinhDoVanHoasResult = dbAtVdc2GetTblHpTrinhDoVanHoasResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblHpTrinhDoVanHoa>("Add Tbl Hp Trinh Do Van Hoa", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa args)
        {
            var result = await DialogService.OpenAsync<EditTblHpTrinhDoVanHoa>("Edit Tbl Hp Trinh Do Van Hoa", new Dictionary<string, object>() { {"TrinhDoVanHoa_ID", args.TrinhDoVanHoa_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblHpTrinhDoVanHoaResult = await DbAtVdc2.DeleteTblHpTrinhDoVanHoa($"{data.TrinhDoVanHoa_ID}");
                if (dbAtVdc2DeleteTblHpTrinhDoVanHoaResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpTrinhDoVanHoaException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpTrinhDoVanHoa");
            }
        }
    }
}
