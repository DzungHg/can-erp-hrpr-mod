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
    public partial class EditTblHpHeDaoTaoComponent : ComponentBase
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
        public dynamic HeDaoTao_ID { get; set; }

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

        CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao _tblhphedaotao;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao tblhphedaotao
        {
            get
            {
                return _tblhphedaotao;
            }
            set
            {
                if(!object.Equals(_tblhphedaotao, value))
                {
                    _tblhphedaotao = value;
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

            var dbAtVdc2GetTblHpHeDaoTaoByHeDaoTaoIdResult = await DbAtVdc2.GetTblHpHeDaoTaoByHeDaoTaoId($"{HeDaoTao_ID}");
            tblhphedaotao = dbAtVdc2GetTblHpHeDaoTaoByHeDaoTaoIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpHeDaoTao args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpHeDaoTaoResult = await DbAtVdc2.UpdateTblHpHeDaoTao($"{HeDaoTao_ID}", tblhphedaotao);
                DialogService.Close(tblhphedaotao);
            }
            catch (Exception dbAtVdc2UpdateTblHpHeDaoTaoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpHeDaoTao");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
