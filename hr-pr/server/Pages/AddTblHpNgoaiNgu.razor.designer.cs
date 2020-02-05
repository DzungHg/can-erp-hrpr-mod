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
    public partial class AddTblHpNgoaiNguComponent : ComponentBase
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
            tblhpngoaingu = new CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpNgoaiNgu args)
        {
            try
            {
                var dbAtVdc2CreateTblHpNgoaiNguResult = await DbAtVdc2.CreateTblHpNgoaiNgu(tblhpngoaingu);
                DialogService.Close(tblhpngoaingu);
            }
            catch (Exception dbAtVdc2CreateTblHpNgoaiNguException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpNgoaiNgu!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
