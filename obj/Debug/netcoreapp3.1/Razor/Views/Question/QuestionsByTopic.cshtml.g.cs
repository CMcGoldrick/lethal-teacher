#pragma checksum "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b529e796015194981459212e648fc37c8ec6ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_QuestionsByTopic), @"mvc.1.0.view", @"/Views/Question/QuestionsByTopic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b529e796015194981459212e648fc37c8ec6ab", @"/Views/Question/QuestionsByTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b216d145f3a8e4f78ff817bb359c70d0ad228d", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_QuestionsByTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lethal.Developer.ViewModels.QuestionViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
  
    ViewData["Title"] = "Detail";
    var cardcollapseId = "#collapseCardExample";
    var collapse = "collapseCardExample";
    var index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 11 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
Write(Model.TopicName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b529e796015194981459212e648fc37c8ec6ab3917", async() => {
                WriteLiteral(@"
    <textarea name=""editor1"" id=""editor1"" rows=""10"" cols=""80""></textarea>
    <script>
        // Replace the <textarea id=""editor1""> with a CKEditor
        // instance, using default configuration.
        CKEDITOR.replace('editor1');
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<button onclick=\"createQuestion()\" class=\"btn-success\">\r\n    Create Question\r\n</button>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
 foreach(var item in Model.Questions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card shadow mb-4\">\r\n        <!-- Card Header - Accordion -->\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 773, 1);
#nullable restore
#line 30 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 748, cardcollapseId + index, 748, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 865, "\"", 900, 1);
#nullable restore
#line 30 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 881, collapse + index, 881, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 31 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
                                                     Write(Html.Raw(item.Q));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </a>\r\n        <!-- Card Content - Collapse -->\r\n        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1071, "\"", 1095, 1);
#nullable restore
#line 34 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1076, collapse + index, 1076, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                ");
#nullable restore
#line 36 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
           Write(Html.Raw(item.A));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
    index++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<script>
    function createQuestion() {
        var iframe = document.getElementsByTagName(""iframe"")[0];
        var html = iframe.contentWindow.document.getElementsByTagName(""html"")[0];
        var body = html.getElementsByTagName(""body"")[0];
        var insideBody = body.querySelectorAll('body > *');

        var returnHtml = """";

        insideBody.forEach(x => returnHtml += x.outerHTML);

        var data = {
            Question: ""what is this baby?"",
            Answer: returnHtml,
            TopicId: ");
#nullable restore
#line 61 "C:\Users\13127\Documents\repos\Lethal.Developer\Views\Question\QuestionsByTopic.cshtml"
                Write(Model.TopicId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        };

        $.ajax({
            type: ""POST"",
            url: '/questions/create',
            //headers: {
            //    'Authorization': `Bearer ${token}`,
            //},
            datatype: ""json"",
            contentType: ""application/json"",
            data: JSON.stringify(data),
            success: function (result) {
                window.location.reload();
            },
            error: function (error) {
            }
        })
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lethal.Developer.ViewModels.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
