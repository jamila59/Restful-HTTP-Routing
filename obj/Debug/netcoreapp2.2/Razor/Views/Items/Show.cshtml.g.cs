#pragma checksum "/Users/Jama/Desktop/c-sharp-to-do-list-week-3-397fce595e3e56dcc038d2b912cd463bdefeeea5/ToDoList/Views/Items/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911a4e4ba129da401f71d1ebb0f82169f6f08da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Show), @"mvc.1.0.view", @"/Views/Items/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Show.cshtml", typeof(AspNetCore.Views_Items_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911a4e4ba129da401f71d1ebb0f82169f6f08da3", @"/Views/Items/Show.cshtml")]
    public class Views_Items_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<h1>To Do List Item Details: </h1>\n\n<h2>");
            EndContext();
            BeginContext(41, 25, false);
#line 3 "/Users/Jama/Desktop/c-sharp-to-do-list-week-3-397fce595e3e56dcc038d2b912cd463bdefeeea5/ToDoList/Views/Items/Show.cshtml"
Write(Model["item"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(66, 20, true);
            WriteLiteral("</h2>\n<h3>Category: ");
            EndContext();
            BeginContext(87, 22, false);
#line 4 "/Users/Jama/Desktop/c-sharp-to-do-list-week-3-397fce595e3e56dcc038d2b912cd463bdefeeea5/ToDoList/Views/Items/Show.cshtml"
         Write(Model["category"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(109, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 118, "\'", 168, 3);
            WriteAttributeValue("", 125, "/categories/", 125, 12, true);
#line 6 "/Users/Jama/Desktop/c-sharp-to-do-list-week-3-397fce595e3e56dcc038d2b912cd463bdefeeea5/ToDoList/Views/Items/Show.cshtml"
WriteAttributeValue("", 137, Model["category"].Id, 137, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 158, "/items/new", 158, 10, true);
            EndWriteAttribute();
            BeginContext(169, 67, true);
            WriteLiteral(">Add another item</a>\n<a href=\'/categories\'>View all categories</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
