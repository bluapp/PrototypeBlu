#pragma checksum "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2906b93edf8c1d04b5a86657d8093894972ce4e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(bLuWebRazor.Pages.Pages_AlteracoesPendentes), @"mvc.1.0.razor-page", @"/Pages/AlteracoesPendentes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AlteracoesPendentes.cshtml", typeof(bLuWebRazor.Pages.Pages_AlteracoesPendentes), null)]
namespace bLuWebRazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/_ViewImports.cshtml"
using bLuWebRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2906b93edf8c1d04b5a86657d8093894972ce4e0", @"/Pages/AlteracoesPendentes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8c163a74ab5ae52edb08db19177498e4a5d85e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AlteracoesPendentes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "AlteracoesPendentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
  
    ViewData["Title"] = "AlteracoesPendentes";

#line default
#line hidden
            BeginContext(108, 72, true);
            WriteLiteral("\n<div class=\"container-fluid linhas\">\n    <h1>Gerenciar Alterações</h1>\n");
            EndContext();
#line 9 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
      
        if (String.IsNullOrEmpty(Model.msg))
        {

#line default
#line hidden
            BeginContext(242, 24, true);
            WriteLiteral("            <p class=\"\">");
            EndContext();
            BeginContext(267, 9, false);
#line 12 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                   Write(Model.msg);

#line default
#line hidden
            EndContext();
            BeginContext(276, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 13 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(313, 31, true);
            WriteLiteral(" <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(345, 9, false);
#line 15 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                                   Write(Model.msg);

#line default
#line hidden
            EndContext();
            BeginContext(354, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 15 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                                                      }
    

#line default
#line hidden
            BeginContext(366, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(370, 1321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2906b93edf8c1d04b5a86657d8093894972ce4e07093", async() => {
                BeginContext(390, 412, true);
                WriteLiteral(@"
        <table class=""table"">
            <thead>
                <tr>
                    <th>Linha</th>
                    <th>Descrição</th>
                    <th>Tarifa</th>
                    <th>Data da Alteração</th>
                    <th>Descrição</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            </thead>
            <tbody id=""tableBody"">
");
                EndContext();
#line 31 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                 foreach (var item in Model.alters)
                {

#line default
#line hidden
                BeginContext(872, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(926, 11, false);
#line 34 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Number);

#line default
#line hidden
                EndContext();
                BeginContext(937, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(972, 16, false);
#line 35 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(988, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1023, 31, false);
#line 36 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Ticket.Price.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1054, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1089, 15, false);
#line 37 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Alter_Date);

#line default
#line hidden
                EndContext();
                BeginContext(1104, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1139, 16, false);
#line 38 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1155, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1190, 11, false);
#line 39 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                       Write(item.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1201, 63, true);
                WriteLiteral("</td>\n                        <td>\n                            ");
                EndContext();
                BeginContext(1264, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2906b93edf8c1d04b5a86657d8093894972ce4e010616", async() => {
                    BeginContext(1371, 7, true);
                    WriteLiteral("Aprovar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 41 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                                                                                                           WriteLiteral(item.Alter_ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1387, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1416, 151, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2906b93edf8c1d04b5a86657d8093894972ce4e013342", async() => {
                    BeginContext(1550, 8, true);
                    WriteLiteral("Cancelar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                                                                                                                                      WriteLiteral(item.Alter_ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1567, 57, true);
                WriteLiteral("\n                        </td>\n                    </tr>\n");
                EndContext();
#line 45 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/AlteracoesPendentes.cshtml"
                }

#line default
#line hidden
                BeginContext(1642, 42, true);
                WriteLiteral("            </tbody>\n        </table>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bLuWebRazor.Pages.AlteracoesPendentesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<bLuWebRazor.Pages.AlteracoesPendentesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<bLuWebRazor.Pages.AlteracoesPendentesModel>)PageContext?.ViewData;
        public bLuWebRazor.Pages.AlteracoesPendentesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
