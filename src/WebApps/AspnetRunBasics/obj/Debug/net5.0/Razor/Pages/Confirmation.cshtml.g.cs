#pragma checksum "D:\tempo\src\WebApps\AspnetRunBasics\Pages\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25efdd3eb6fd85a8bb2b3f5340d4d4e95944493b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspnetRunBasics.Pages.Pages_Confirmation), @"mvc.1.0.razor-page", @"/Pages/Confirmation.cshtml")]
namespace AspnetRunBasics.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\_ViewImports.cshtml"
using AspnetRunBasics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\_ViewImports.cshtml"
using AspnetRunBasics.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25efdd3eb6fd85a8bb2b3f5340d4d4e95944493b", @"/Pages/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e7173edc2935479c2083bac8eedf6c2cbc617d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container contact-container\">\n    <h1 class=\"mt-4 mb-3\">\n        Confirmation        \n    </h1>\n    <hr />\n");
#nullable restore
#line 12 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\Confirmation.cshtml"
     if (!string.IsNullOrEmpty(Model.Message))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 14 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\Confirmation.cshtml"
       Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 15 "D:\tempo\src\WebApps\AspnetRunBasics\Pages\Confirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>If you have any further questions, you can contact us 501-222-2222.</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspnetRunBasics.ConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRunBasics.ConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRunBasics.ConfirmationModel>)PageContext?.ViewData;
        public AspnetRunBasics.ConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
