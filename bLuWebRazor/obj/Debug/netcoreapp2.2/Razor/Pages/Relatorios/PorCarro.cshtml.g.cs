#pragma checksum "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6b0c573f3b5a1b7ac1fc1824e029ffac00fb09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(bLuWebRazor.Pages.Relatorios.Pages_Relatorios_PorCarro), @"mvc.1.0.razor-page", @"/Pages/Relatorios/PorCarro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Relatorios/PorCarro.cshtml", typeof(bLuWebRazor.Pages.Relatorios.Pages_Relatorios_PorCarro), null)]
namespace bLuWebRazor.Pages.Relatorios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6b0c573f3b5a1b7ac1fc1824e029ffac00fb09", @"/Pages/Relatorios/PorCarro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8c163a74ab5ae52edb08db19177498e4a5d85e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Relatorios_PorCarro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
  
    ViewData["Title"] = "PorCarro";

#line default
#line hidden
            BeginContext(97, 91, true);
            WriteLiteral("\n<div style=\"padding-left: 5%; padding-right: 5%;\">\n\n    <h1>Relatório Por Carro</h1>\n\n    ");
            EndContext();
            BeginContext(188, 2829, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6b0c573f3b5a1b7ac1fc1824e029ffac00fb093787", async() => {
                BeginContext(208, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(501, 237, true);
                WriteLiteral("\n        <table class=\"table table-striped\">\n            <thead>\n                <tr>\n                    <th scope=\"col\">QR Code</th>\n                    <th scope=\"col\">Placa</th>\n                    <th scope=\"col\">Identificador</th>\n");
                EndContext();
                BeginContext(796, 489, true);
                WriteLiteral(@"                    <th scope=""col"">ID do Usuário</th>
                    <th scope=""col"">Nome Usuário</th>
                    <th scope=""col"">ID da Viagem</th>
                    <th scope=""col"">Abertura</th>
                    <th scope=""col"">Fechamento</th>
                    <th scope=""col"">Linha</th>
                    <th scope=""col"">Motorista</th>
                    <th scope=""col"">Tarifa</th>
                </tr>
            </thead>
            <tbody id=""tableBody"">
");
                EndContext();
#line 37 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                 for (int i = 0; i < Model.relatorioDT.Rows.Count; i++)
                {

#line default
#line hidden
                BeginContext(1375, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(1429, 46, false);
#line 40 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["qrcode"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1475, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1510, 53, false);
#line 41 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["license_plate"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1563, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1598, 46, false);
#line 42 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["qrcode"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1644, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
                BeginContext(1740, 28, true);
                WriteLiteral("                        <td>");
                EndContext();
                BeginContext(1769, 54, false);
#line 44 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["travel_user_id"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1823, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1858, 49, false);
#line 45 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["user_name"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1907, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1942, 49, false);
#line 46 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["travel_id"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1991, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(2026, 95, false);
#line 47 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(DateTime.Parse(Model.relatorioDT.Rows[i]["start_time"].ToString()).ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(2121, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 48 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                          
                            if (String.IsNullOrEmpty(Model.relatorioDT.Rows[i]["finish_time"].ToString()))
                            {

#line default
#line hidden
                BeginContext(2291, 65, true);
                WriteLiteral("                                <td>Viagem ainda em aberto!</td>\n");
                EndContext();
#line 52 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(2449, 36, true);
                WriteLiteral("                                <td>");
                EndContext();
                BeginContext(2486, 96, false);
#line 55 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                               Write(DateTime.Parse(Model.relatorioDT.Rows[i]["finish_time"].ToString()).ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(2582, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 56 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(2644, 28, true);
                WriteLiteral("                        <td>");
                EndContext();
                BeginContext(2673, 44, false);
#line 58 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["line"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2717, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(2752, 51, false);
#line 59 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(Model.relatorioDT.Rows[i]["driver_name"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2803, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(2838, 80, false);
#line 60 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                       Write(double.Parse(Model.relatorioDT.Rows[i]["price_ticket"].ToString()).ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(2918, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 62 "/home/igor/projects/blu/PrototypeBlu/bLuWebRazor/Pages/Relatorios/PorCarro.cshtml"
                }

#line default
#line hidden
                BeginContext(2968, 42, true);
                WriteLiteral("            </tbody>\n        </table>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3017, 7, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bLuWebRazor.Pages.Relatorios.PorCarroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<bLuWebRazor.Pages.Relatorios.PorCarroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<bLuWebRazor.Pages.Relatorios.PorCarroModel>)PageContext?.ViewData;
        public bLuWebRazor.Pages.Relatorios.PorCarroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
