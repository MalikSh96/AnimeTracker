#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30cda5da32e386f73c0645250a399fb15aad5ac"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30cda5da32e386f73c0645250a399fb15aad5ac", @"/Views/Anime/MoreInfo.cshtml")]
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
            BeginContext(34, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(59, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25aee52db5104d1387a45ff99ace0b09", async() => {
                BeginContext(65, 87, true);
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
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(161, 2469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "924173f6ce1c4d099f9df848a99da710", async() => {
                BeginContext(167, 142, true);
                WriteLiteral("\r\n    <a href=\"##\" onClick=\"history.go(-1); return false;\" class=\"bodylink\"> <b>Return to previous page</b></a>\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 11 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            var data = ViewData.Model;
        

#line default
#line hidden
                BeginContext(372, 15, true);
                WriteLiteral("        <h2><b>");
                EndContext();
                BeginContext(388, 14, false);
#line 14 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          Write(data.animename);

#line default
#line hidden
                EndContext();
                BeginContext(402, 59, true);
                WriteLiteral("</b></h2>\r\n        <h4><b>Description</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(462, 16, false);
#line 16 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.description);

#line default
#line hidden
                EndContext();
                BeginContext(478, 68, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Show type</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(547, 14, false);
#line 19 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.show_type);

#line default
#line hidden
                EndContext();
                BeginContext(561, 76, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Total of Episodes</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(638, 13, false);
#line 22 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.episodes);

#line default
#line hidden
                EndContext();
                BeginContext(651, 54, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Airing</b></h4>\r\n");
                EndContext();
#line 25 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            if (!data.airing)
            {

#line default
#line hidden
                BeginContext(763, 35, true);
                WriteLiteral("                <p>Not airing</p>\r\n");
                EndContext();
#line 29 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(846, 31, true);
                WriteLiteral("                <p>Airing</p>\r\n");
                EndContext();
#line 33 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
            }
        

#line default
#line hidden
                BeginContext(903, 58, true);
                WriteLiteral("        <br />\r\n        <h4><b>Genre</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(962, 10, false);
#line 37 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.genre);

#line default
#line hidden
                EndContext();
                BeginContext(972, 65, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Studio</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(1038, 11, false);
#line 40 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.studio);

#line default
#line hidden
                EndContext();
                BeginContext(1049, 65, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Source</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(1115, 17, false);
#line 43 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.anime_source);

#line default
#line hidden
                EndContext();
                BeginContext(1132, 68, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Rating PG</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(1201, 14, false);
#line 46 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.rating_pg);

#line default
#line hidden
                EndContext();
                BeginContext(1215, 77, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Anime Release Date</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(1293, 17, false);
#line 49 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.release_date);

#line default
#line hidden
                EndContext();
                BeginContext(1310, 70, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Broadcaster</b></h4>\r\n        <p>");
                EndContext();
                BeginContext(1381, 16, false);
#line 52 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
      Write(data.broadcaster);

#line default
#line hidden
                EndContext();
                BeginContext(1397, 74, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <h4><b>Official Website</b></h4>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1471, "\"", 1492, 1);
#line 55 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
WriteAttributeValue("", 1478, data.off_link, 1478, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1493, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1495, 13, false);
#line 55 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
                            Write(data.off_link);

#line default
#line hidden
                EndContext();
                BeginContext(1508, 40, true);
                WriteLiteral("</a>\r\n        <br />\r\n        <br />\r\n\r\n");
                EndContext();
#line 59 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
          
            /*
             What I am doing here is basically cutting down some of first elements
             of the path.
             The part that gets removed is wwwrooot, because is wwwroot is included in the path
             for the src, the url link will mess up, and no images will be shown as the web can't
             find the correct link for it
             */
            

#line default
#line hidden
#line 68 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
                                                             

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
                BeginContext(2519, 20, true);
                WriteLiteral("                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2539, "\"", 2554, 1);
#line 79 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
WriteAttributeValue("", 2545, imageUrl, 2545, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2555, 30, true);
                WriteLiteral(" width=\"400\" height=\"400\" />\r\n");
                EndContext();
#line 80 "C:\Users\malik\OneDrive\Documents\Projects\AnimeProject\AnimeTracker\AnimeTracker\Views\Anime\MoreInfo.cshtml"
            }
        

#line default
#line hidden
                BeginContext(2611, 12, true);
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
            BeginContext(2630, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
