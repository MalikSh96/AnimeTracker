#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30151034954f142004641c3274d3bdebcd5995c6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30151034954f142004641c3274d3bdebcd5995c6", @"/Views/Anime/MoreInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b6648958856c9a3be8da1b77f5434ced73cba2", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(33, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(58, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b4b9e89bc84aa293da9e45f1a95f11", async() => {
                BeginContext(64, 84, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Anime</title>\n");
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
            BeginContext(155, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(156, 1764, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7357bfaf06544db4861ce007e96c16aa", async() => {
                BeginContext(162, 29, true);
                WriteLiteral("\n    <div class=\"container\">\n");
                EndContext();
#line 12 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            var data = ViewData.Model;
        

#line default
#line hidden
                BeginContext(251, 15, true);
                WriteLiteral("        <h2><b>");
                EndContext();
                BeginContext(267, 14, false);
#line 15 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          Write(data.animename);

#line default
#line hidden
                EndContext();
                BeginContext(281, 58, true);
                WriteLiteral("</b></h2>\n\n        <h4><b>Description</b></h4>\n        <p>");
                EndContext();
                BeginContext(340, 16, false);
#line 18 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.description);

#line default
#line hidden
                EndContext();
                BeginContext(356, 73, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Total of Episodes</b></h4>\n        <p>");
                EndContext();
                BeginContext(430, 13, false);
#line 21 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.episodes);

#line default
#line hidden
                EndContext();
                BeginContext(443, 61, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Genre</b></h4>\n        <p>");
                EndContext();
                BeginContext(505, 10, false);
#line 24 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.genre);

#line default
#line hidden
                EndContext();
                BeginContext(515, 62, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Studio</b></h4>\n        <p>");
                EndContext();
                BeginContext(578, 11, false);
#line 27 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.studio);

#line default
#line hidden
                EndContext();
                BeginContext(589, 62, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Source</b></h4>\n        <p>");
                EndContext();
                BeginContext(652, 17, false);
#line 30 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.anime_source);

#line default
#line hidden
                EndContext();
                BeginContext(669, 65, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Rating PG</b></h4>\n        <p>");
                EndContext();
                BeginContext(735, 14, false);
#line 33 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.rating_pg);

#line default
#line hidden
                EndContext();
                BeginContext(749, 74, true);
                WriteLiteral("</p>\n        <br />\n        <h4><b>Anime Release Date</b></h4>\n        <p>");
                EndContext();
                BeginContext(824, 17, false);
#line 36 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.release_date);

#line default
#line hidden
                EndContext();
                BeginContext(841, 20, true);
                WriteLiteral("</p>\n        <br />\n");
                EndContext();
#line 38 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            /*
             What I am doing here is basically cutting down some of first elements
             of the path.
             The part that gets removed is wwwrooot, because is wwwroot is included in the path
             for the src, the url link will mess up, and no images will be shown as the web can't
             find the correct link for it
             */
            

#line default
#line hidden
#line 47 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
                                                             

            /*
            The below code loops through our ImageList variable
            which has the images within their given folders
            data.animename is used to point to the desired imagefolder 
            and image is used to select the images in their corresponding folders
             */
            foreach (var image in ViewBag.ImageList)
            {
                var imageUrl = $"/animeimages/{data.animename}/" + image;

#line default
#line hidden
                BeginContext(1813, 20, true);
                WriteLiteral("                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1833, "\"", 1848, 1);
#line 58 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
WriteAttributeValue("", 1839, imageUrl, 1839, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1849, 29, true);
                WriteLiteral(" width=\"400\" height=\"400\" />\n");
                EndContext();
#line 59 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1902, 11, true);
                WriteLiteral("    </div>\n");
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
            BeginContext(1920, 11, true);
            WriteLiteral("\n</html>\n\n\n");
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
