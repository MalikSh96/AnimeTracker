#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0047af4b299f4be53332279c6f58c32923c32c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_MoreInfo), @"mvc.1.0.view", @"/Views/Anime/MoreInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anime/MoreInfo.cshtml", typeof(AspNetCore.Views_Anime_MoreInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0047af4b299f4be53332279c6f58c32923c32c9", @"/Views/Anime/MoreInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab0c36180e0fed3642eee4db40f7b9fa4bf21d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_MoreInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeTracker.Models.Anime>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(63, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff54ad0e152a4d588e1c7a81858605f4", async() => {
                BeginContext(69, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Anime</title>\r\n");
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
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 1268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617901aad0384e92b48d69a22a3b3c2a", async() => {
                BeginContext(171, 31, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 12 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            var data = ViewData.Model;
        

#line default
#line hidden
                BeginContext(265, 15, true);
                WriteLiteral("        <h2><b>");
                EndContext();
                BeginContext(281, 14, false);
#line 15 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          Write(data.animename);

#line default
#line hidden
                EndContext();
                BeginContext(295, 61, true);
                WriteLiteral("</b></h2>\r\n\r\n        <h4><b>Description</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(357, 16, false);
#line 18 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.description);

#line default
#line hidden
                EndContext();
                BeginContext(373, 76, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Total of Episodes</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(450, 13, false);
#line 21 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.episodes);

#line default
#line hidden
                EndContext();
                BeginContext(463, 64, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Genre</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(528, 10, false);
#line 24 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.genre);

#line default
#line hidden
                EndContext();
                BeginContext(538, 65, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Studio</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(604, 11, false);
#line 27 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.studio);

#line default
#line hidden
                EndContext();
                BeginContext(615, 65, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Source</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(681, 17, false);
#line 30 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.anime_source);

#line default
#line hidden
                EndContext();
                BeginContext(698, 68, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Rating PG</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(767, 14, false);
#line 33 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.rating_pg);

#line default
#line hidden
                EndContext();
                BeginContext(781, 77, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Anime Release Date</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(859, 17, false);
#line 36 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.release_date);

#line default
#line hidden
                EndContext();
                BeginContext(876, 22, true);
                WriteLiteral("</p>\r\n        <br />\r\n");
                EndContext();
#line 38 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            /*
             What I am doing here is basically cutting down some of first elements
             of the path.
             The part that gets removed is wwwrooot, because is wwwroot is included in the path
             for the src, the url link will mess up, and no images will be shown as the web can't
             find the correct link for it
             */ 
            var img = data.img_path.Substring(7);

#line default
#line hidden
                BeginContext(1345, 16, true);
                WriteLiteral("            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1361, "\"", 1371, 1);
#line 47 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
WriteAttributeValue("", 1367, img, 1367, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1372, 30, true);
                WriteLiteral(" width=\"400\" height=\"400\" />\r\n");
                EndContext();
                BeginContext(1414, 12, true);
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
            BeginContext(1433, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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