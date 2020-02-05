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
    public partial class EditTblHpTrinhDoChuyenMonComponent : ComponentBase
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
        public dynamic TrinhDoChuyenMon_ID { get; set; }

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
            canEdit = true;

            var dbAtVdc2GetTblHpTrinhDoChuyenMonByTrinhDoChuyenMonIdResult = await DbAtVdc2.GetTblHpTrinhDoChuyenMonByTrinhDoChuyenMonId($"{TrinhDoChuyenMon_ID}");
            tblhptrinhdochuyenmon = dbAtVdc2GetTblHpTrinhDoChuyenMonByTrinhDoChuyenMonIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpTrinhDoChuyenMon args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpTrinhDoChuyenMonResult = await DbAtVdc2.UpdateTblHpTrinhDoChuyenMon($"{TrinhDoChuyenMon_ID}", tblhptrinhdochuyenmon);
                DialogService.Close(tblhptrinhdochuyenmon);
            }
            catch (Exception dbAtVdc2UpdateTblHpTrinhDoChuyenMonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpTrinhDoChuyenMon");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
