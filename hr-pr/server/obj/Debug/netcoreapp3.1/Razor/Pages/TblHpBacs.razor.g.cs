#pragma checksum "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a398d1c926898cf6f9f1fee4c034e36f6346a4"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErpHrPr.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using CanErpHrPr.Shared;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-hp-bacs")]
    public partial class TblHpBacs : CanErpHrPr.Pages.TblHpBacsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Hp Bacs");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                     getTblHpBacsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblHpBac>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(28);
                    __builder3.AddAttribute(29, "Property", "Bac_ID");
                    __builder3.AddAttribute(30, "Title", "Bac ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(32);
                    __builder3.AddAttribute(33, "Property", "Bac_Name");
                    __builder3.AddAttribute(34, "Title", "Bac Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(36);
                    __builder3.AddAttribute(37, "Property", "HeSoLuong");
                    __builder3.AddAttribute(38, "Title", "He So Luong");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(40);
                    __builder3.AddAttribute(41, "Property", "Ngach_FK");
                    __builder3.AddAttribute(42, "SortProperty", "TblHpNgach.Ngach_Name");
                    __builder3.AddAttribute(43, "FilterProperty", "TblHpNgach.Ngach_Name");
                    __builder3.AddAttribute(44, "Title", "Tbl Hp Ngach");
                    __builder3.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpBac>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(46, "\n              ");
                        __builder4.AddContent(47, 
#line 26 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                data.TblHpNgach?.Ngach_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(48, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(50);
                    __builder3.AddAttribute(51, "Property", "Description");
                    __builder3.AddAttribute(52, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpBac>>(54);
                    __builder3.AddAttribute(55, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 31 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(56, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 31 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(57, "Width", "70px");
                    __builder3.AddAttribute(58, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 31 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                                                                                                 TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpBac>)((canErpHrPrModelsDbAtVdc2TblHpBac) => (__builder4) => {
                        __builder4.AddMarkupContent(60, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(61);
                        __builder4.AddAttribute(62, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 33 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(63, "Icon", "close");
                        __builder4.AddAttribute(64, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 33 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(65, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErpHrPrModelsDbAtVdc2TblHpBac)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(66, "onclick", 
#line 33 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                                                                                                                                                                                                                true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(67, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(69, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpBacs.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpBac>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
