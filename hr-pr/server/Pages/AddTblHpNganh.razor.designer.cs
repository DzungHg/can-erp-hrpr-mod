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
    public partial class AddTblHpNganhComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpNganh _tblhpnganh;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpNganh tblhpnganh
        {
            get
            {
                return _tblhpnganh;
            }
            set
            {
                if(!object.Equals(_tblhpnganh, value))
                {
                    _tblhpnganh = value;
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
            tblhpnganh = new CanErpHrPr.Models.DbAtVdc2.TblHpNganh();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpNganh args)
        {
            try
            {
                var dbAtVdc2CreateTblHpNganhResult = await DbAtVdc2.CreateTblHpNganh(tblhpnganh);
                DialogService.Close(tblhpnganh);
            }
            catch (Exception dbAtVdc2CreateTblHpNganhException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpNganh!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
