#pragma checksum "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b82e3eda07ad5c7480f73506a109cec15dee16a"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-hp-chi-tiet-cong-tacs")]
    public partial class TblHpChiTietCongTacs : CanErpHrPr.Pages.TblHpChiTietCongTacsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Hp Chi Tiet Cong Tacs");
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
#line 14 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                     getTblHpChiTietCongTacsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                                                                                                                       Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(28);
                    __builder3.AddAttribute(29, "Property", "ChiTietCongTac_SEQ");
                    __builder3.AddAttribute(30, "Title", "Chi Tiet Cong Tac SEQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(32);
                    __builder3.AddAttribute(33, "Property", "NhanVien_FK");
                    __builder3.AddAttribute(34, "SortProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(35, "FilterProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(36, "Title", "Tbl Hp Nhan Vien");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                data.TblHpNhanVien?.HoTenLot

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(42);
                    __builder3.AddAttribute(43, "Property", "NgayBienDong");
                    __builder3.AddAttribute(44, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Ngay Bien Dong");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(47);
                    __builder3.AddAttribute(48, "Property", "QuyetDinhSo");
                    __builder3.AddAttribute(49, "Title", "Quyet Dinh So");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(51);
                    __builder3.AddAttribute(52, "Property", "DonViCu");
                    __builder3.AddAttribute(53, "Title", "Don Vi Cu");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(55);
                    __builder3.AddAttribute(56, "Property", "ChucVuCu");
                    __builder3.AddAttribute(57, "Title", "Chuc Vu Cu");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(59);
                    __builder3.AddAttribute(60, "Property", "DonViHienNay");
                    __builder3.AddAttribute(61, "Title", "Don Vi Hien Nay");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(63);
                    __builder3.AddAttribute(64, "Property", "ChucVuHienNay");
                    __builder3.AddAttribute(65, "Title", "Chuc Vu Hien Nay");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>>(67);
                    __builder3.AddAttribute(68, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(69, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(70, "Width", "70px");
                    __builder3.AddAttribute(71, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 37 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>)((canErpHrPrModelsDbAtVdc2TblHpChiTietCongTac) => (__builder4) => {
                        __builder4.AddMarkupContent(73, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(74);
                        __builder4.AddAttribute(75, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(76, "Icon", "close");
                        __builder4.AddAttribute(77, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(78, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErpHrPrModelsDbAtVdc2TblHpChiTietCongTac)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(79, "onclick", 
#line 39 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                                                                                                                                                                                                                           true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(82, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp-hrpr-mod\hr-pr\server\Pages\TblHpChiTietCongTacs.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietCongTac>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
