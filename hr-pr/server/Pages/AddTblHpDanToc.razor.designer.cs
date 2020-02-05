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
    public partial class AddTblHpDanTocComponent : ComponentBase
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

        CanErpHrPr.Models.DbAtVdc2.TblHpDanToc _tblhpdantoc;
        protected CanErpHrPr.Models.DbAtVdc2.TblHpDanToc tblhpdantoc
        {
            get
            {
                return _tblhpdantoc;
            }
            set
            {
                if(!object.Equals(_tblhpdantoc, value))
                {
                    _tblhpdantoc = value;
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
            tblhpdantoc = new CanErpHrPr.Models.DbAtVdc2.TblHpDanToc();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHrPr.Models.DbAtVdc2.TblHpDanToc args)
        {
            try
            {
                var dbAtVdc2CreateTblHpDanTocResult = await DbAtVdc2.CreateTblHpDanToc(tblhpdantoc);
                DialogService.Close(tblhpdantoc);
            }
            catch (Exception dbAtVdc2CreateTblHpDanTocException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpDanToc!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
