#pragma checksum "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b13bfa12d0e6be3cb59da39ceda03fda5aa3f25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication.Pages.Person.Pages_Person_index), @"mvc.1.0.razor-page", @"/Pages/Person/index.cshtml")]
namespace WebApplication.Pages.Person
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
#line 1 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b13bfa12d0e6be3cb59da39ceda03fda5aa3f25", @"/Pages/Person/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed418d440d938fb6141a3a9470c71231e3c986f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Person_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
  
    ViewData["Title"] = "index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>P E O P L E</h1>\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 9 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
     foreach (var person in Model.People)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">");
#nullable restore
#line 12 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
                            Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"card-body\">\r\n            <p style=\"font-size:small\">POSITION: ");
#nullable restore
#line 14 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
                                            Write(person.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-size:small\">COMPANY: ");
#nullable restore
#line 15 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
                                           Write(person.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\gian.gerard\Downloads\dotNet\WebApp-vStudio\WebApplication\WebApplication\Pages\Person\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Website.indexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Website.indexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Website.indexModel>)PageContext?.ViewData;
        public WebApplication.Website.indexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
