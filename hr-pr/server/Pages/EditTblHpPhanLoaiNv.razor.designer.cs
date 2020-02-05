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
    public partial class EditTblHpPhanLoaiNvComponent : ComponentBase
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
        public dynamic PhanLoaiNV_ID { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv _tblhpphanloainv;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv tblhpphanloainv
        {
            get
            {
                return _tblhpphanloainv;
            }
            set
            {
                if(!object.Equals(_tblhpphanloainv, value))
                {
                    _tblhpphanloainv = value;
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

            var dbAtVdc2GetTblHpPhanLoaiNvByPhanLoaiNvIdResult = await DbAtVdc2.GetTblHpPhanLoaiNvByPhanLoaiNvId($"{PhanLoaiNV_ID}");
            tblhpphanloainv = dbAtVdc2GetTblHpPhanLoaiNvByPhanLoaiNvIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpPhanLoaiNvResult = await DbAtVdc2.UpdateTblHpPhanLoaiNv($"{PhanLoaiNV_ID}", tblhpphanloainv);
                DialogService.Close(tblhpphanloainv);
            }
            catch (Exception dbAtVdc2UpdateTblHpPhanLoaiNvException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpPhanLoaiNv");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
