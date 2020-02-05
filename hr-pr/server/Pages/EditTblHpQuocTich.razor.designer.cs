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
    public partial class EditTblHpQuocTichComponent : ComponentBase
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
        public dynamic QuocTich_ID { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich _tblhpquoctich;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich tblhpquoctich
        {
            get
            {
                return _tblhpquoctich;
            }
            set
            {
                if(!object.Equals(_tblhpquoctich, value))
                {
                    _tblhpquoctich = value;
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

            var dbAtVdc2GetTblHpQuocTichByQuocTichIdResult = await DbAtVdc2.GetTblHpQuocTichByQuocTichId($"{QuocTich_ID}");
            tblhpquoctich = dbAtVdc2GetTblHpQuocTichByQuocTichIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpQuocTich args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpQuocTichResult = await DbAtVdc2.UpdateTblHpQuocTich($"{QuocTich_ID}", tblhpquoctich);
                DialogService.Close(tblhpquoctich);
            }
            catch (Exception dbAtVdc2UpdateTblHpQuocTichException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpQuocTich");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
