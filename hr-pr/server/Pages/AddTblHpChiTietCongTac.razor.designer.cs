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
    public partial class AddTblHpChiTietCongTacComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac _tblhpchitietcongtac;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac tblhpchitietcongtac
        {
            get
            {
                return _tblhpchitietcongtac;
            }
            set
            {
                if(!object.Equals(_tblhpchitietcongtac, value))
                {
                    _tblhpchitietcongtac = value;
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

            tblhpchitietcongtac = new CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac args)
        {
            try
            {
                var dbAtVdc2CreateTblHpChiTietCongTacResult = await DbAtVdc2.CreateTblHpChiTietCongTac(tblhpchitietcongtac);
                DialogService.Close(tblhpchitietcongtac);
            }
            catch (Exception dbAtVdc2CreateTblHpChiTietCongTacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpChiTietCongTac!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
