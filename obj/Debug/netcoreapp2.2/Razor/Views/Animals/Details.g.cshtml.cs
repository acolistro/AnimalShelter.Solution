#pragma checksum "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6f3371176e436c308ef9d22aaf73b6410556632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Details), @"mvc.1.0.view", @"/Views/Animals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animals/Details.cshtml", typeof(AspNetCore.Views_Animals_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f3371176e436c308ef9d22aaf73b6410556632", @"/Views/Animals/Details.cshtml")]
    public class Views_Animals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimalShelter.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 39, true);
            WriteLiteral("\r\n<h2>Animal Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(108, 47, false);
#line 9 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(155, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(158, 43, false);
#line 9 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(201, 10, true);
            WriteLiteral("</h3>\r\n<p>");
            EndContext();
            BeginContext(212, 40, false);
#line 10 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(252, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelter.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
