#pragma checksum "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1cbc525aa5916729f3e67f54f5e11de1fd1d22"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-hp-chi-tiet-gia-canhs")]
    public partial class TblHpChiTietGiaCanhs : CanErpHrPr.Pages.TblHpChiTietGiaCanhsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Hp Chi Tiet Gia Canhs");
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
#line 14 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                     getTblHpChiTietGiaCanhsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                                                                                                                       Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(28);
                    __builder3.AddAttribute(29, "Property", "ChiTietGiaCanh_SEQ");
                    __builder3.AddAttribute(30, "Title", "Chi Tiet Gia Canh SEQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(32);
                    __builder3.AddAttribute(33, "Property", "NhanVien_FK");
                    __builder3.AddAttribute(34, "SortProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(35, "FilterProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(36, "Title", "Tbl Hp Nhan Vien");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                data.TblHpNhanVien?.HoTenLot

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(42);
                    __builder3.AddAttribute(43, "Property", "HoVaTen");
                    __builder3.AddAttribute(44, "Title", "Ho Va Ten");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(46);
                    __builder3.AddAttribute(47, "Property", "NamSinh");
                    __builder3.AddAttribute(48, "Title", "Nam Sinh");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(50);
                    __builder3.AddAttribute(51, "Property", "PhaiNam");
                    __builder3.AddAttribute(52, "Title", "Phai Nam");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(54);
                    __builder3.AddAttribute(55, "Property", "QuanHe");
                    __builder3.AddAttribute(56, "Title", "Quan He");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(58);
                    __builder3.AddAttribute(59, "Property", "NgheNghiep");
                    __builder3.AddAttribute(60, "Title", "Nghe Nghiep");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(62);
                    __builder3.AddAttribute(63, "Property", "DaChet");
                    __builder3.AddAttribute(64, "Title", "Da Chet");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>>(66);
                    __builder3.AddAttribute(67, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(69, "Width", "70px");
                    __builder3.AddAttribute(70, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>)((canErpHrPrModelsDbAtVdc2TblHpChiTietGiaCanh) => (__builder4) => {
                        __builder4.AddMarkupContent(72, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(73);
                        __builder4.AddAttribute(74, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(75, "Icon", "close");
                        __builder4.AddAttribute(76, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(77, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErpHrPrModelsDbAtVdc2TblHpChiTietGiaCanh)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(78, "onclick", 
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                                                                                                                                                                                                                           true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(79, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(81, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietGiaCanhs.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietGiaCanh>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
