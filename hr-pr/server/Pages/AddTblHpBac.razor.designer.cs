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
    public partial class AddTblHpBacComponent : ComponentBase
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

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> _getTblHpNgachesResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNgach> getTblHpNgachesResult
        {
            get
            {
                return _getTblHpNgachesResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNgachesResult, value))
                {
                    _getTblHpNgachesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        CanErpHrPr.Models.DbAtVdc2.TblHpBac _tblhpbac;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpBac tblhpbac
        {
            get
            {
                return _tblhpbac;
            }
            set
            {
                if(!object.Equals(_tblhpbac, value))
                {
                    _tblhpbac = value;
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
            var dbAtVdc2GetTblHpNgachesResult = await DbAtVdc2.GetTblHpNgaches();
            getTblHpNgachesResult = dbAtVdc2GetTblHpNgachesResult;

            tblhpbac = new CanErpHrPr.Models.DbAtVdc2.TblHpBac();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpBac args)
        {
            try
            {
                var dbAtVdc2CreateTblHpBacResult = await DbAtVdc2.CreateTblHpBac(tblhpbac);
                DialogService.Close(tblhpbac);
            }
            catch (Exception dbAtVdc2CreateTblHpBacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpBac!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
