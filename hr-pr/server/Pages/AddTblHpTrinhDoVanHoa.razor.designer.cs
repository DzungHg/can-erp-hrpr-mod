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
    public partial class AddTblHpTrinhDoVanHoaComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa _tblhptrinhdovanhoa;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa tblhptrinhdovanhoa
        {
            get
            {
                return _tblhptrinhdovanhoa;
            }
            set
            {
                if(!object.Equals(_tblhptrinhdovanhoa, value))
                {
                    _tblhptrinhdovanhoa = value;
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
            tblhptrinhdovanhoa = new CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoVanHoa args)
        {
            try
            {
                var dbAtVdc2CreateTblHpTrinhDoVanHoaResult = await DbAtVdc2.CreateTblHpTrinhDoVanHoa(tblhptrinhdovanhoa);
                DialogService.Close(tblhptrinhdovanhoa);
            }
            catch (Exception dbAtVdc2CreateTblHpTrinhDoVanHoaException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpTrinhDoVanHoa!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
