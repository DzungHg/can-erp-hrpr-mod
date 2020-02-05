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
    public partial class EditTblHpXiNghiepComponent : ComponentBase
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
        public dynamic XiNghiep_ID { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep _tblhpxinghiep;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep tblhpxinghiep
        {
            get
            {
                return _tblhpxinghiep;
            }
            set
            {
                if(!object.Equals(_tblhpxinghiep, value))
                {
                    _tblhpxinghiep = value;
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

            var dbAtVdc2GetTblHpXiNghiepByXiNghiepIdResult = await DbAtVdc2.GetTblHpXiNghiepByXiNghiepId($"{XiNghiep_ID}");
            tblhpxinghiep = dbAtVdc2GetTblHpXiNghiepByXiNghiepIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpXiNghiepResult = await DbAtVdc2.UpdateTblHpXiNghiep($"{XiNghiep_ID}", tblhpxinghiep);
                DialogService.Close(tblhpxinghiep);
            }
            catch (Exception dbAtVdc2UpdateTblHpXiNghiepException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpXiNghiep");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
