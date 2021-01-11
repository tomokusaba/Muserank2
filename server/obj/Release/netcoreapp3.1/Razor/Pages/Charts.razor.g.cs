#pragma checksum "G:\prj\muserank2\server\Pages\Charts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b9503cf2b47179614546e245b091d0d4bbba973"
// <auto-generated/>
#pragma warning disable 1591
namespace Muserank2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\prj\muserank2\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "G:\prj\muserank2\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "G:\prj\muserank2\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "G:\prj\muserank2\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "G:\prj\muserank2\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "G:\prj\muserank2\server\_Imports.razor"
using Muserank2.Shared;

#line default
#line hidden
#line 6 "G:\prj\muserank2\server\Pages\Charts.razor"
using Radzen;

#line default
#line hidden
#line 7 "G:\prj\muserank2\server\Pages\Charts.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "G:\prj\muserank2\server\Pages\Charts.razor"
using Muserank2.Models.Muse;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/charts")]
    public partial class Charts : Muserank2.Pages.ChartsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Charts");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(11);
                __builder2.AddAttribute(12, "Icon", "get_app");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px; margin-left: 0px");
                __builder2.AddAttribute(14, "Text", "Export");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#line 15 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                  Splitbutton0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(17);
                    __builder3.AddAttribute(18, "Text", "Excel");
                    __builder3.AddAttribute(19, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(21);
                    __builder3.AddAttribute(22, "Text", "CSV");
                    __builder3.AddAttribute(23, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(25);
                __builder2.AddAttribute(26, "Placeholder", "Search ...");
                __builder2.AddAttribute(27, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(28, "Name", "Textbox0");
                __builder2.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 23 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                                         async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Muserank2.Models.Muse.Chart>>(31);
                __builder2.AddAttribute(32, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(33, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(34, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                            true

#line default
#line hidden
                ));
                __builder2.AddAttribute(35, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Muserank2.Models.Muse.Chart>>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                         getChartsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(36, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                                      FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                                                                                                         50

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(39);
                    __builder3.AddAttribute(40, "Property", "NENDO");
                    __builder3.AddAttribute(41, "Title", "NENDO");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(43);
                    __builder3.AddAttribute(44, "Property", "GENRE");
                    __builder3.AddAttribute(45, "Title", "GENRE");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(47);
                    __builder3.AddAttribute(48, "Property", "HYOKA_NUM");
                    __builder3.AddAttribute(49, "Title", "HYOKA NUM");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(51);
                    __builder3.AddAttribute(52, "Property", "KYOKU_NAME");
                    __builder3.AddAttribute(53, "Title", "KYOKU NAME");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(55);
                    __builder3.AddAttribute(56, "Property", "AUTHOR_NAME");
                    __builder3.AddAttribute(57, "Title", "AUTHOR NAME");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(59);
                    __builder3.AddAttribute(60, "Property", "HOUR");
                    __builder3.AddAttribute(61, "Title", "HOUR");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(63);
                    __builder3.AddAttribute(64, "Property", "MINUTE");
                    __builder3.AddAttribute(65, "Title", "MINUTE");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(67);
                    __builder3.AddAttribute(68, "Property", "SECOND");
                    __builder3.AddAttribute(69, "Title", "SECOND");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(71);
                    __builder3.AddAttribute(72, "Property", "MEMBER");
                    __builder3.AddAttribute(73, "Title", "MEMBER");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(75);
                    __builder3.AddAttribute(76, "Property", "FILE_SIZE");
                    __builder3.AddAttribute(77, "Title", "FILE SIZE");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Muserank2.Models.Muse.Chart>>(79);
                    __builder3.AddAttribute(80, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 47 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                      false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(81, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 47 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(82, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 47 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                         TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(83, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 47 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(84, "Width", "70px");
                    __builder3.AddAttribute(85, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Muserank2.Models.Muse.Chart>)((muserank2ModelsMuseChart) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(86);
                        __builder4.AddAttribute(87, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 49 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                       ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(88, "Icon", "close");
                        __builder4.AddAttribute(89, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 49 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                              ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(90, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 49 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                         (args) =>GridDeleteButtonClick(args, muserank2ModelsMuseChart)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(91, "onclick", 
#line 49 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                                                                                                                                                                                    true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(92, (__value) => {
#line 25 "G:\prj\muserank2\server\Pages\Charts.razor"
                              grid0 = (Radzen.Blazor.RadzenGrid<Muserank2.Models.Muse.Chart>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(94);
                __builder2.AddAttribute(95, "Style", "height:800px;");
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.Muserank2.Pages.Charts.TypeInference.CreateRadzenBarSeries_0(__builder3, 97, 98, 
#line 56 "G:\prj\muserank2\server\Pages\Charts.razor"
                                        getChartsResult.GroupBy(x => x.AUTHOR_NAME).Select( x => new { Name = x.Key, FileSize = x.Sum(y => y.FILE_SIZE)}).OrderBy(x => x.FileSize).Where(x => x.FileSize >= 1024*256)

#line default
#line hidden
                    , 99, "Bytes", 100, "FileSize", 101, "Name");
                    __builder3.AddMarkupContent(102, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(103);
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(105);
                        __builder4.AddAttribute(106, "Text", "作者別ファイルサイズ最大");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(108);
                __builder2.AddAttribute(109, "Style", "height:800px;");
                __builder2.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.Muserank2.Pages.Charts.TypeInference.CreateRadzenBarSeries_1(__builder3, 111, 112, 
#line 63 "G:\prj\muserank2\server\Pages\Charts.razor"
                                        getChartsResult.GroupBy(x => x.AUTHOR_NAME).Select( x => new { Name = x.Key, FileSize = (double)(x.Count(y => y.HYOKA_NUM >= 2)) / x.Count(y => y.FILE_SIZE >= 0), KyokuSu = x.Count(y => y.FILE_SIZE >= 0)}).OrderBy(x => x.FileSize).Where(x => x.KyokuSu >= 20)

#line default
#line hidden
                    , 113, "★獲得率", 114, "FileSize", 115, "Name");
                    __builder3.AddMarkupContent(116, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(117);
                    __builder3.AddAttribute(118, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 64 "G:\prj\muserank2\server\Pages\Charts.razor"
                                      1.0

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(119, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 64 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                0

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(120, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 64 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                         0.1

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(122);
                        __builder4.AddAttribute(123, "Text", "★獲得率　登録20曲以上");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(125);
                __builder2.AddAttribute(126, "Style", "height:800px;");
                __builder2.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.Muserank2.Pages.Charts.TypeInference.CreateRadzenBarSeries_2(__builder3, 128, 129, 
#line 70 "G:\prj\muserank2\server\Pages\Charts.razor"
                                        getChartsResult.GroupBy(x => x.AUTHOR_NAME).Select( x => new { Name = x.Key, FileSize = (double)(x.Count(y => y.HYOKA_NUM >= 1)) / x.Count(y => y.FILE_SIZE >= 0), KyokuSu = x.Count(y => y.FILE_SIZE >= 0)}).OrderBy(x => x.FileSize).Where(x => x.KyokuSu >= 20)

#line default
#line hidden
                    , 130, "☆以上獲得率", 131, "FileSize", 132, "Name");
                    __builder3.AddMarkupContent(133, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(134);
                    __builder3.AddAttribute(135, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 71 "G:\prj\muserank2\server\Pages\Charts.razor"
                                      1.0

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(136, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 71 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                0

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(137, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 71 "G:\prj\muserank2\server\Pages\Charts.razor"
                                                         0.1

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(139);
                        __builder4.AddAttribute(140, "Text", "☆以上獲得率　登録20曲以上");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Muserank2.Pages.Charts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenBarSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenBarSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "CategoryProperty", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenBarSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenBarSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "CategoryProperty", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenBarSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenBarSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "CategoryProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591