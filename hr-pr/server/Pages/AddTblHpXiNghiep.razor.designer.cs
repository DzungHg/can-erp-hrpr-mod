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
    public partial class AddTblHpXiNghiepComponent : ComponentBase
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
            tblhpxinghiep = new CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpXiNghiep args)
        {
            try
            {
                var dbAtVdc2CreateTblHpXiNghiepResult = await DbAtVdc2.CreateTblHpXiNghiep(tblhpxinghiep);
                DialogService.Close(tblhpxinghiep);
            }
            catch (Exception dbAtVdc2CreateTblHpXiNghiepException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpXiNghiep!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
