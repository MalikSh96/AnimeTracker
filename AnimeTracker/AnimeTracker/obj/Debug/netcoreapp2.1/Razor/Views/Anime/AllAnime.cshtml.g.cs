#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a59cadd6037923b553eb7bec1fa760efbdd8eb7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_AllAnime), @"mvc.1.0.view", @"/Views/Anime/AllAnime.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anime/AllAnime.cshtml", typeof(AspNetCore.Views_Anime_AllAnime))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\_ViewImports.cshtml"
using AnimeTracker;

#line default
#line hidden
#line 2 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\_ViewImports.cshtml"
using AnimeTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59cadd6037923b553eb7bec1fa760efbdd8eb7e", @"/Views/Anime/AllAnime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab0c36180e0fed3642eee4db40f7b9fa4bf21d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_AllAnime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeTracker.Models.Anime>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewscss/getall.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 47, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(81, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410e18f349174a769f6f365d2c663219", async() => {
                BeginContext(87, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Anime</title>\r\n\r\n    ");
                EndContext();
                BeginContext(180, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1fafa869caef416eba871b6850fa1719", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(238, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(249, 3029, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a9443b8f40342b581dca679dc957593", async() => {
                BeginContext(255, 75, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h3><b>List of all Animes</b></h3>\r\n");
                EndContext();
                BeginContext(569, 406, true);
                WriteLiteral(@"        <table class=""table table-striped"" id=""datatable"">
            <thead>
                <tr>
                    <th></th>
                    <th>Anime Name</th>
                    <th>Total of Episodes</th>
                    <th>Airing</th>
                    <th>Anime Release Date</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 34 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                 foreach (var anime in ViewBag.Anime)
                {

#line default
#line hidden
                BeginContext(1049, 63, true);
                WriteLiteral("                <tr class=\"Search\">\r\n                    <td>\r\n");
                EndContext();
#line 38 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                          
                            if (!String.IsNullOrEmpty(anime.img_path))
                            {
                                var imageUrl = $"{anime.img_path.Substring(7)}";

#line default
#line hidden
                BeginContext(1325, 36, true);
                WriteLiteral("                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1361, "\"", 1376, 1);
#line 42 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
WriteAttributeValue("", 1367, imageUrl, 1367, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1377, 29, true);
                WriteLiteral(" width=\"120\" height=\"75\" />\r\n");
                EndContext();
#line 43 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1464, 54, true);
                WriteLiteral("                    </td>\r\n                    <td><b>");
                EndContext();
                BeginContext(1519, 15, false);
#line 46 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                      Write(anime.animename);

#line default
#line hidden
                EndContext();
                BeginContext(1534, 35, true);
                WriteLiteral("</b></td>\r\n                    <td>");
                EndContext();
                BeginContext(1570, 14, false);
#line 47 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                   Write(anime.episodes);

#line default
#line hidden
                EndContext();
                BeginContext(1584, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 48 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                     if (!anime.airing)
                    {

#line default
#line hidden
                BeginContext(1655, 45, true);
                WriteLiteral("                        <td>Not airing</td>\r\n");
                EndContext();
#line 51 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1772, 41, true);
                WriteLiteral("                        <td>Airing</td>\r\n");
                EndContext();
#line 55 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                    }

#line default
#line hidden
                BeginContext(1836, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(1861, 18, false);
#line 56 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                   Write(anime.release_date);

#line default
#line hidden
                EndContext();
                BeginContext(1879, 59, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1938, "\"", 1969, 2);
                WriteAttributeValue("", 1945, "moreinfo/", 1945, 9, true);
#line 58 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
WriteAttributeValue("", 1954, anime.anime_id, 1954, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1970, 94, true);
                WriteLiteral(" class=\"seemore\"><b>>>More Details</b></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 61 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\AllAnime.cshtml"
                }

#line default
#line hidden
                BeginContext(2083, 42, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n");
                EndContext();
                BeginContext(3259, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3278, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeTracker.Models.Anime> Html { get; private set; }
    }
}
#pragma warning restore 1591
