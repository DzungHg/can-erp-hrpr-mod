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
    public partial class AddTblHpPhanLoaiNvComponent : ComponentBase
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
            tblhpphanloainv = new CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpPhanLoaiNv args)
        {
            try
            {
                var dbAtVdc2CreateTblHpPhanLoaiNvResult = await DbAtVdc2.CreateTblHpPhanLoaiNv(tblhpphanloainv);
                DialogService.Close(tblhpphanloainv);
            }
            catch (Exception dbAtVdc2CreateTblHpPhanLoaiNvException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpPhanLoaiNv!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
