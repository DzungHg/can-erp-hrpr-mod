#pragma checksum "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d25689f0adc3732e17ca8ea26b1ad982ce8a514"
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
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-gn-department/{Department_ID}")]
    public partial class EditTblGnDepartment : CanErpHrPr.Pages.EditTblGnDepartmentComponent
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
#line 12 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
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
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>(
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                      tblgndepartment

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                                                  tblgndepartment != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>(this, 
#line 22 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
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
                    __builder3.AddAttribute(49, "Text", "Department Id");
                    __builder3.AddAttribute(50, "Component", "Department_ID");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(57);
                    __builder3.AddAttribute(58, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                          5

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(60, "Name", "Department_ID");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                                tblgndepartment.Department_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgndepartment.Department_ID = __value, tblgndepartment.Department_ID))));
                    __builder3.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblgndepartment.Department_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(65);
                    __builder3.AddAttribute(66, "Component", "Department_ID");
                    __builder3.AddAttribute(67, "Text", "Department_ID is required");
                    __builder3.AddAttribute(68, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(74, "class", "row");
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-3");
                    __builder3.AddMarkupContent(78, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Text", "Deparment Name");
                    __builder3.AddAttribute(81, "Component", "Deparment_Name");
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-9");
                    __builder3.AddMarkupContent(87, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(88);
                    __builder3.AddAttribute(89, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                          15

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Name", "Deparment_Name");
                    __builder3.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                 tblgndepartment.Deparment_Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgndepartment.Deparment_Name = __value, tblgndepartment.Deparment_Name))));
                    __builder3.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblgndepartment.Deparment_Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col-md-3");
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(105);
                    __builder3.AddAttribute(106, "Text", "Description");
                    __builder3.AddAttribute(107, "Component", "Description");
                    __builder3.AddAttribute(108, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(114);
                    __builder3.AddAttribute(115, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 52 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                          150

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(116, "style", "width: 100%");
                    __builder3.AddAttribute(117, "Name", "Description");
                    __builder3.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 52 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                  tblgndepartment.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgndepartment.Description = __value, tblgndepartment.Description))));
                    __builder3.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblgndepartment.Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(122, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(123, "\n            ");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "row");
                    __builder3.AddMarkupContent(126, "\n              ");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(129, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(130);
                    __builder3.AddAttribute(131, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 58 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(132, "Icon", "save");
                    __builder3.AddAttribute(133, "Text", "Save");
                    __builder3.AddAttribute(134, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(136);
                    __builder3.AddAttribute(137, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 60 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "Text", "Cancel");
                    __builder3.AddAttribute(139, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\EditTblGnDepartment.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(143, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
