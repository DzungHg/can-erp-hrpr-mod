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
    public partial class EditTblHpChiTietNgoaiNguComponent : ComponentBase
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
        public dynamic ChiTietNgoaiNgu_SEQ { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu _tblhpchitietngoaingu;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu tblhpchitietngoaingu
        {
            get
            {
                return _tblhpchitietngoaingu;
            }
            set
            {
                if(!object.Equals(_tblhpchitietngoaingu, value))
                {
                    _tblhpchitietngoaingu = value;
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

            var dbAtVdc2GetTblHpChiTietNgoaiNguByChiTietNgoaiNguSeqResult = await DbAtVdc2.GetTblHpChiTietNgoaiNguByChiTietNgoaiNguSeq(int.Parse($"{ChiTietNgoaiNgu_SEQ}"));
            tblhpchitietngoaingu = dbAtVdc2GetTblHpChiTietNgoaiNguByChiTietNgoaiNguSeqResult;

            var dbAtVdc2GetTblHpNhanViensResult = await DbAtVdc2.GetTblHpNhanViens();
            getTblHpNhanViensResult = dbAtVdc2GetTblHpNhanViensResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpChiTietNgoaiNguResult = await DbAtVdc2.UpdateTblHpChiTietNgoaiNgu(int.Parse($"{ChiTietNgoaiNgu_SEQ}"), tblhpchitietngoaingu);
                DialogService.Close(tblhpchitietngoaingu);
            }
            catch (Exception dbAtVdc2UpdateTblHpChiTietNgoaiNguException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpChiTietNgoaiNgu");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
