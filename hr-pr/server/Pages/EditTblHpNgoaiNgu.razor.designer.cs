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
    public partial class EditTblHpNgoaiNguComponent : ComponentBase
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
        public dynamic NgoaiNgu_ID { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu _tblhpngoaingu;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu tblhpngoaingu
        {
            get
            {
                return _tblhpngoaingu;
            }
            set
            {
                if(!object.Equals(_tblhpngoaingu, value))
                {
                    _tblhpngoaingu = value;
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

            var dbAtVdc2GetTblHpNgoaiNguByNgoaiNguIdResult = await DbAtVdc2.GetTblHpNgoaiNguByNgoaiNguId($"{NgoaiNgu_ID}");
            tblhpngoaingu = dbAtVdc2GetTblHpNgoaiNguByNgoaiNguIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpNgoaiNguResult = await DbAtVdc2.UpdateTblHpNgoaiNgu($"{NgoaiNgu_ID}", tblhpngoaingu);
                DialogService.Close(tblhpngoaingu);
            }
            catch (Exception dbAtVdc2UpdateTblHpNgoaiNguException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpNgoaiNgu");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
