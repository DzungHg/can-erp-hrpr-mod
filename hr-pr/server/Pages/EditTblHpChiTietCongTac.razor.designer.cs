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
    public partial class EditTblHpChiTietCongTacComponent : ComponentBase
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
        public dynamic ChiTietCongTac_SEQ { get; set; }

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            canEdit = true;

            var dbAtVdc2GetTblHpChiTietCongTacByChiTietCongTacSeqResult = await DbAtVdc2.GetTblHpChiTietCongTacByChiTietCongTacSeq(int.Parse($"{ChiTietCongTac_SEQ}"));
            tblhpchitietcongtac = dbAtVdc2GetTblHpChiTietCongTacByChiTietCongTacSeqResult;

            var dbAtVdc2GetTblHpNhanViensResult = await DbAtVdc2.GetTblHpNhanViens();
            getTblHpNhanViensResult = dbAtVdc2GetTblHpNhanViensResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpChiTietCongTacResult = await DbAtVdc2.UpdateTblHpChiTietCongTac(int.Parse($"{ChiTietCongTac_SEQ}"), tblhpchitietcongtac);
                DialogService.Close(tblhpchitietcongtac);
            }
            catch (Exception dbAtVdc2UpdateTblHpChiTietCongTacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpChiTietCongTac");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
