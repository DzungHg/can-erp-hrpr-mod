﻿using System;
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
    public partial class EditTblHpLoaiChamCongComponent : ComponentBase
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
        public dynamic LoaiChamCong_ID { get; set; }

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
            canEdit = true;

            var dbAtVdc2GetTblHpLoaiChamCongByLoaiChamCongIdResult = await DbAtVdc2.GetTblHpLoaiChamCongByLoaiChamCongId($"{LoaiChamCong_ID}");
            tblhploaichamcong = dbAtVdc2GetTblHpLoaiChamCongByLoaiChamCongIdResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpLoaiChamCong args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpLoaiChamCongResult = await DbAtVdc2.UpdateTblHpLoaiChamCong($"{LoaiChamCong_ID}", tblhploaichamcong);
                DialogService.Close(tblhploaichamcong);
            }
            catch (Exception dbAtVdc2UpdateTblHpLoaiChamCongException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpLoaiChamCong");
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
