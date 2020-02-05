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
    public partial class AddTblHpLoaiChamCongComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong _tblhploaichamcong;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong tblhploaichamcong
        {
            get
            {
                return _tblhploaichamcong;
            }
            set
            {
                if(!object.Equals(_tblhploaichamcong, value))
                {
                    _tblhploaichamcong = value;
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
            tblhploaichamcong = new CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong args)
        {
            try
            {
                var dbAtVdc2CreateTblHpLoaiChamCongResult = await DbAtVdc2.CreateTblHpLoaiChamCong(tblhploaichamcong);
                DialogService.Close(tblhploaichamcong);
            }
            catch (Exception dbAtVdc2CreateTblHpLoaiChamCongException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpLoaiChamCong!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
