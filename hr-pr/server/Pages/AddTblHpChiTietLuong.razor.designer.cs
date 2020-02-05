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
    public partial class AddTblHpChiTietLuongComponent : ComponentBase
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

        IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> _getTblHpNhanViensResult;
        protected IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpNhanVien> getTblHpNhanViensResult
        {
            get
            {
                return _getTblHpNhanViensResult;
            }
            set
            {
                if(!object.Equals(_getTblHpNhanViensResult, value))
                {
                    _getTblHpNhanViensResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong _tblhpchitietluong;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong tblhpchitietluong
        {
            get
            {
                return _tblhpchitietluong;
            }
            set
            {
                if(!object.Equals(_tblhpchitietluong, value))
                {
                    _tblhpchitietluong = value;
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
            var dbAtVdc2GetTblHpNhanViensResult = await DbAtVdc2.GetTblHpNhanViens();
            getTblHpNhanViensResult = dbAtVdc2GetTblHpNhanViensResult;

            tblhpchitietluong = new CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietLuong args)
        {
            try
            {
                var dbAtVdc2CreateTblHpChiTietLuongResult = await DbAtVdc2.CreateTblHpChiTietLuong(tblhpchitietluong);
                DialogService.Close(tblhpchitietluong);
            }
            catch (Exception dbAtVdc2CreateTblHpChiTietLuongException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpChiTietLuong!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
