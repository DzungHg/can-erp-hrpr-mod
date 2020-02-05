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
    public partial class AddTblHpTrinhDoChuyenMonComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon _tblhptrinhdochuyenmon;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon tblhptrinhdochuyenmon
        {
            get
            {
                return _tblhptrinhdochuyenmon;
            }
            set
            {
                if(!object.Equals(_tblhptrinhdochuyenmon, value))
                {
                    _tblhptrinhdochuyenmon = value;
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
            tblhptrinhdochuyenmon = new CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon args)
        {
            try
            {
                var dbAtVdc2CreateTblHpTrinhDoChuyenMonResult = await DbAtVdc2.CreateTblHpTrinhDoChuyenMon(tblhptrinhdochuyenmon);
                DialogService.Close(tblhptrinhdochuyenmon);
            }
            catch (Exception dbAtVdc2CreateTblHpTrinhDoChuyenMonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpTrinhDoChuyenMon!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
