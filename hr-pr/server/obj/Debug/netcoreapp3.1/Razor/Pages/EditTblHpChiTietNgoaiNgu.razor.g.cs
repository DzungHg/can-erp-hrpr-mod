#pragma checksum "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "601b88e2691d7d635303ae95192758212c802eaf"
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
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-hp-chi-tiet-ngoai-ngu/{ChiTietNgoaiNgu_SEQ}")]
    public partial class EditTblHpChiTietNgoaiNgu : CanErpHrPr.Pages.EditTblHpChiTietNgoaiNguComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", true);
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n      ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-9");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", "Item no longer available.");
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                           !canEdit

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-3");
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                __builder2.AddAttribute(21, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-12");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu>(
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                           tblhpchitietngoaingu

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                                            tblhpchitietngoaingu != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblHpChiTietNgoaiNgu>(this, 
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                                                                                               Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Tbl Hp Nhan Vien");
                    __builder3.AddAttribute(50, "Component", "NhanVien_FK");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __Blazor.CanErpHrPr.Pages.EditTblHpChiTietNgoaiNgu.TypeInference.CreateRadzenDropDown_0(__builder3, 57, 58, 
#line 30 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                       getTblHpNhanViensResult

#line default
#line hidden
                    , 59, "HoTenLot", 60, "NhanVien_ID", 61, "Choose TblHpNhanVien", 62, "width: 100%", 63, "NhanVien_FK", 64, 
#line 30 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                                                                                                          tblhpchitietngoaingu.NhanVien_FK

#line default
#line hidden
                    , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpchitietngoaingu.NhanVien_FK = __value, tblhpchitietngoaingu.NhanVien_FK)), 66, () => tblhpchitietngoaingu.NhanVien_FK);
                    __builder3.AddMarkupContent(67, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(72, "class", "row");
                    __builder3.AddMarkupContent(73, "\n              ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "col-md-3");
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(77);
                    __builder3.AddAttribute(78, "Text", "Ngoai Ngu Fk");
                    __builder3.AddAttribute(79, "Component", "NgoaiNgu_FK");
                    __builder3.AddAttribute(80, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n              ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "col-md-9");
                    __builder3.AddMarkupContent(85, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(86);
                    __builder3.AddAttribute(87, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 40 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                          2

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(88, "style", "width: 100%");
                    __builder3.AddAttribute(89, "Name", "NgoaiNgu_FK");
                    __builder3.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                tblhpchitietngoaingu.NgoaiNgu_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpchitietngoaingu.NgoaiNgu_FK = __value, tblhpchitietngoaingu.NgoaiNgu_FK))));
                    __builder3.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpchitietngoaingu.NgoaiNgu_FK));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(98, "class", "row");
                    __builder3.AddMarkupContent(99, "\n              ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col-md-3");
                    __builder3.AddMarkupContent(102, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
                    __builder3.AddAttribute(104, "Text", "Trinh Do Fk");
                    __builder3.AddAttribute(105, "Component", "TrinhDo_FK");
                    __builder3.AddAttribute(106, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n              ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-9");
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(112);
                    __builder3.AddAttribute(113, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 50 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                          2

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.AddAttribute(115, "Name", "TrinhDo_FK");
                    __builder3.AddAttribute(116, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 50 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                tblhpchitietngoaingu.TrinhDo_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(117, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpchitietngoaingu.TrinhDo_FK = __value, tblhpchitietngoaingu.TrinhDo_FK))));
                    __builder3.AddAttribute(118, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpchitietngoaingu.TrinhDo_FK));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n            ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(124, "class", "row");
                    __builder3.AddMarkupContent(125, "\n              ");
                    __builder3.OpenElement(126, "div");
                    __builder3.AddAttribute(127, "class", "col-md-3");
                    __builder3.AddMarkupContent(128, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(129);
                    __builder3.AddAttribute(130, "Text", "Van Bang");
                    __builder3.AddAttribute(131, "Component", "VanBang");
                    __builder3.AddAttribute(132, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-9");
                    __builder3.AddMarkupContent(137, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(138);
                    __builder3.AddAttribute(139, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 60 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                          25

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(140, "style", "width: 100%");
                    __builder3.AddAttribute(141, "Name", "VanBang");
                    __builder3.AddAttribute(142, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 60 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                 tblhpchitietngoaingu.VanBang

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(143, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpchitietngoaingu.VanBang = __value, tblhpchitietngoaingu.VanBang))));
                    __builder3.AddAttribute(144, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpchitietngoaingu.VanBang));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n            ");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "class", "row");
                    __builder3.AddMarkupContent(150, "\n              ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(153, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(154);
                    __builder3.AddAttribute(155, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 66 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(156, "Icon", "save");
                    __builder3.AddAttribute(157, "Text", "Save");
                    __builder3.AddAttribute(158, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 66 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(160);
                    __builder3.AddAttribute(161, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 68 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(162, "Text", "Cancel");
                    __builder3.AddAttribute(163, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 68 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblHpChiTietNgoaiNgu.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(164, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(165, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(167, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErpHrPr.Pages.EditTblHpChiTietNgoaiNgu
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
