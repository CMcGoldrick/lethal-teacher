#pragma checksum "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Shared\_TopicsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f95abe3af42c2414ed4bcc2fc28a65db2139501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TopicsPartial), @"mvc.1.0.view", @"/Views/Shared/_TopicsPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\_ViewImports.cshtml"
using Lethal.Developer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\_ViewImports.cshtml"
using Lethal.Developer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f95abe3af42c2414ed4bcc2fc28a65db2139501", @"/Views/Shared/_TopicsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b216d145f3a8e4f78ff817bb359c70d0ad228d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TopicsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lethal.Developer.ViewModels.TopicViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div>");
#nullable restore
#line 8 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Shared\_TopicsPartial.cshtml"
Write(Model.FirstOrDefault().Name);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lethal.Developer.ViewModels.TopicViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
