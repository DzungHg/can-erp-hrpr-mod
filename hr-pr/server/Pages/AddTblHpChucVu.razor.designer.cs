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
    public partial class AddTblHpChucVuComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpChucVu _tblhpchucvu;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpChucVu tblhpchucvu
        {
            get
            {
                return _tblhpchucvu;
            }
            set
            {
                if(!object.Equals(_tblhpchucvu, value))
                {
                    _tblhpchucvu = value;
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
            tblhpchucvu = new CanErpHrPr.Models.DbAtVdc2.TblHpChucVu();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpChucVu args)
        {
            try
            {
                var dbAtVdc2CreateTblHpChucVuResult = await DbAtVdc2.CreateTblHpChucVu(tblhpchucvu);
                DialogService.Close(tblhpchucvu);
            }
            catch (Exception dbAtVdc2CreateTblHpChucVuException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpChucVu!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
