#pragma checksum "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd0d36bb6d646b79a099c8119d5bd2ee9c54070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Index), @"mvc.1.0.view", @"/Views/Animals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animals/Index.cshtml", typeof(AspNetCore.Views_Animals_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
#line 6 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd0d36bb6d646b79a099c8119d5bd2ee9c54070", @"/Views/Animals/Index.cshtml")]
    public class Views_Animals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimalShelter.Models.Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 22, true);
            WriteLiteral("\r\n<h1>Animals</h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(191, 44, true);
            WriteLiteral("  <h3>No animals have been added yet!</h3>\r\n");
            EndContext();
#line 14 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
 foreach (Animal animal in Model)
{

#line default
#line hidden
            BeginContext(279, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(286, 75, false);
#line 18 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
 Write(Html.ActionLink($"{animal.Description}", "Details", new { id = animal.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(361, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
}

#line default
#line hidden
            BeginContext(371, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(377, 43, false);
#line 21 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Index.cshtml"
Write(Html.ActionLink("Add new animal", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(420, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimalShelter.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
