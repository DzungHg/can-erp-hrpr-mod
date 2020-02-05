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
    public partial class EditTblHpBacComponent : ComponentBase
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

        [Parameter]
        public dynamic Bac_ID { get; set; }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(!object.Equals(_canEdit, value))
                {
                    _canEdit = value;
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            canEdit = true;

            var dbAtVdc2GetTblHpBacByBacIdResult = await DbAtVdc2.GetTblHpBacByBacId($"{Bac_ID}");
            tblhpbac = dbAtVdc2GetTblHpBacByBacIdResult;

            var dbAtVdc2GetTblHpNgachesResult = await DbAtVdc2.GetTblHpNgaches();
            getTblHpNgachesResult = dbAtVdc2GetTblHpNgachesResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpBac args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpBacResult = await DbAtVdc2.UpdateTblHpBac($"{Bac_ID}", tblhpbac);
                DialogService.Close(tblhpbac);
            }
            catch (Exception dbAtVdc2UpdateTblHpBacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpBac");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
