#pragma checksum "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95992ce00081a9ad4f44c179fe1772fc6b36ee0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_ShowComment), @"mvc.1.0.view", @"/Views/Course/ShowComment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/ShowComment.cshtml", typeof(AspNetCore.Views_Course_ShowComment))]
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
#line 1 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
using Pelika.Core.Convertors;

#line default
#line hidden
#line 2 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
using Pelika.DataLayer.Entities.Course;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95992ce00081a9ad4f44c179fe1772fc6b36ee0e", @"/Views/Course/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Pelika.DataLayer.Entities.Course.CourseComment>, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
 foreach (var item in Model.Item1)
{

#line default
#line hidden
            BeginContext(217, 43, true);
            WriteLiteral("    <div class=\"comment-row\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 260, "\"", 299, 2);
            WriteAttributeValue("", 266, "/UserAvatar/", 266, 12, true);
#line 13 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
WriteAttributeValue("", 278, item.User.UserAvatar, 278, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 52, true);
            WriteLiteral(">\r\n        <div class=\"left-col\">\r\n            <h3> ");
            EndContext();
            BeginContext(353, 18, false);
#line 15 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
            Write(item.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(371, 26, true);
            WriteLiteral(" </h3>\r\n            <span>");
            EndContext();
            BeginContext(398, 26, false);
#line 16 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
             Write(item.CreateDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(424, 42, true);
            WriteLiteral("</span>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(467, 12, false);
#line 18 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
           Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(479, 48, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 22 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
}

#line default
#line hidden
            BeginContext(530, 102, true);
            WriteLiteral("\r\n\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        \r\n");
            EndContext();
#line 28 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
         for (int i = 1; i <= Model.Item2; i++)
        {

#line default
#line hidden
            BeginContext(692, 54, true);
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 746, "\"", 771, 3);
            WriteAttributeValue("", 756, "pageComment(", 756, 12, true);
#line 30 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
WriteAttributeValue("", 768, i, 768, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 770, ")", 770, 1, true);
            EndWriteAttribute();
            BeginContext(772, 2, true);
            WriteLiteral(" >");
            EndContext();
            BeginContext(775, 1, false);
#line 30 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(776, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 31 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\ShowComment.cshtml"
        }

#line default
#line hidden
            BeginContext(798, 31, true);
            WriteLiteral("        \r\n    </ul>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Pelika.DataLayer.Entities.Course.CourseComment>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
