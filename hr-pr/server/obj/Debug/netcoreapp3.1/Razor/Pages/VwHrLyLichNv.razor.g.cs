#pragma checksum "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f36db8d174b3cd54968771af58ed727bb349fc66"
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
#line 1 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using CanErpHrPr.Shared;

#line default
#line hidden
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/vw-hr-ly-lich-nv")]
    public partial class VwHrLyLichNv : CanErpHrPr.Pages.VwHrLyLichNvComponent
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
                __builder2.AddAttribute(6, "Text", "Vw Hr Ly Lich Nv");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 14 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                  ButtonType.Button

#line default
#line hidden
                ));
                __builder2.AddAttribute(16, "Text", "Thêm ");
                __builder2.AddAttribute(17, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                                          Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(19);
                __builder2.AddAttribute(20, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(21, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                                                                     getVwHrLyLichNvsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>(this, 
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                                                                                                                                                                                         Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(25, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(27);
                    __builder3.AddAttribute(28, "Property", "NhanVien_ID");
                    __builder3.AddAttribute(29, "Title", "Nhan Vien ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(31);
                    __builder3.AddAttribute(32, "Property", "HoTenLot");
                    __builder3.AddAttribute(33, "Title", "Ho Ten Lot");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(35);
                    __builder3.AddAttribute(36, "Property", "Ten");
                    __builder3.AddAttribute(37, "Title", "Ten");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(39);
                    __builder3.AddAttribute(40, "Property", "MaTheChamCong");
                    __builder3.AddAttribute(41, "Title", "Ma The Cham Cong");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(43);
                    __builder3.AddAttribute(44, "Property", "PhaiNam");
                    __builder3.AddAttribute(45, "Title", "Phai Nam");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(47);
                    __builder3.AddAttribute(48, "Property", "HinhAnh");
                    __builder3.AddAttribute(49, "Title", "Hinh Anh");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(51);
                    __builder3.AddAttribute(52, "FormatString", "{0:d}");
                    __builder3.AddAttribute(53, "Property", "NgayThangNamSinh");
                    __builder3.AddAttribute(54, "Title", "Ngay Thang Nam Sinh");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(56);
                    __builder3.AddAttribute(57, "Property", "NamSinh");
                    __builder3.AddAttribute(58, "Title", "Nam Sinh");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(60);
                    __builder3.AddAttribute(61, "Property", "NoiSinh_FK");
                    __builder3.AddAttribute(62, "Title", "Noi Sinh FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(64);
                    __builder3.AddAttribute(65, "Property", "QueQuan_FK");
                    __builder3.AddAttribute(66, "Title", "Que Quan FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(68);
                    __builder3.AddAttribute(69, "Property", "DanToc_FK");
                    __builder3.AddAttribute(70, "Title", "Dan Toc FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(72);
                    __builder3.AddAttribute(73, "Property", "TonGiao_FK");
                    __builder3.AddAttribute(74, "Title", "Ton Giao FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(76);
                    __builder3.AddAttribute(77, "Property", "QuocTich_FK");
                    __builder3.AddAttribute(78, "Title", "Quoc Tich FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(80);
                    __builder3.AddAttribute(81, "Property", "SoCMND");
                    __builder3.AddAttribute(82, "Title", "So CMND");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(84);
                    __builder3.AddAttribute(85, "FormatString", "{0:d}");
                    __builder3.AddAttribute(86, "Property", "NgayCapCMND");
                    __builder3.AddAttribute(87, "Title", "Ngay Cap CMND");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(89);
                    __builder3.AddAttribute(90, "Property", "NoiCapCMND");
                    __builder3.AddAttribute(91, "Title", "Noi Cap CMND");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(93);
                    __builder3.AddAttribute(94, "Property", "HoKhau");
                    __builder3.AddAttribute(95, "Title", "Ho Khau");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(97);
                    __builder3.AddAttribute(98, "Property", "QuanHoKhau_FK");
                    __builder3.AddAttribute(99, "Title", "Quan Ho Khau FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(101);
                    __builder3.AddAttribute(102, "Property", "TinhTPHoKhau_FK");
                    __builder3.AddAttribute(103, "Title", "Tinh TP Ho Khau FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(105);
                    __builder3.AddAttribute(106, "Property", "ChoOHienNay");
                    __builder3.AddAttribute(107, "Title", "Cho O Hien Nay");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(109);
                    __builder3.AddAttribute(110, "Property", "QuanChoOHienNay_FK");
                    __builder3.AddAttribute(111, "Title", "Quan Cho O Hien Nay FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(113);
                    __builder3.AddAttribute(114, "Property", "TinhTPChoOHienNay_FK");
                    __builder3.AddAttribute(115, "Title", "Tinh TP Cho O Hien Nay FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(117);
                    __builder3.AddAttribute(118, "Property", "SoDienThoai");
                    __builder3.AddAttribute(119, "Title", "So Dien Thoai");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(121);
                    __builder3.AddAttribute(122, "Property", "Email");
                    __builder3.AddAttribute(123, "Title", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(125);
                    __builder3.AddAttribute(126, "Property", "MaSoThueCaNhan");
                    __builder3.AddAttribute(127, "Title", "Ma So Thue Ca Nhan");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(128, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(129);
                    __builder3.AddAttribute(130, "Property", "TaiKhoanThanhToan");
                    __builder3.AddAttribute(131, "Title", "Tai Khoan Thanh Toan");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(133);
                    __builder3.AddAttribute(134, "Property", "HoTenATM");
                    __builder3.AddAttribute(135, "Title", "Ho Ten ATM");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(137);
                    __builder3.AddAttribute(138, "Property", "MaKeToan");
                    __builder3.AddAttribute(139, "Title", "Ma Ke Toan");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>>(141);
                    __builder3.AddAttribute(142, "FormatString", "{0:d}");
                    __builder3.AddAttribute(143, "Property", "NgayNhatTu");
                    __builder3.AddAttribute(144, "Title", "Ngay Nhat Tu");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(146, (__value) => {
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\VwHrLyLichNv.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.VwHrLyLichNv>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
