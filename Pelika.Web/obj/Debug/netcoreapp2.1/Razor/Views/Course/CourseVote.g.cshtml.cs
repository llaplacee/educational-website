#pragma checksum "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\CourseVote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5130b35cc5b3fa8deb73f83571d75c8ee7e2ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseVote), @"mvc.1.0.view", @"/Views/Course/CourseVote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/CourseVote.cshtml", typeof(AspNetCore.Views_Course_CourseVote))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5130b35cc5b3fa8deb73f83571d75c8ee7e2ac", @"/Views/Course/CourseVote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseVote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<int,int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\CourseVote.cshtml"
 if (User.Identity.IsAuthenticated && ViewBag.NotAccess==null)
{
    


#line default
#line hidden
            BeginContext(100, 279, true);
            WriteLiteral(@"    <div class=""row"">
        <img src=""https://toplearn.com/img/votew.jpg"" />
        <p></p>
        <p>
            <a class=""btn btn-success"" onclick=""vote(true)"">
                <img class=""btnLike"" src=""https://toplearn.com/img/like.png"" />
                میپسندم (");
            EndContext();
            BeginContext(380, 11, false);
#line 13 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\CourseVote.cshtml"
                    Write(Model.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(391, 194, true);
            WriteLiteral(")\r\n            </a>\r\n            <a class=\"btn btn-danger\" onclick=\"vote(false)\">\r\n                <img class=\"btnLike\" src=\"https://toplearn.com/img/dislike.png\" />\r\n                نمی پسندم (");
            EndContext();
            BeginContext(586, 11, false);
#line 17 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\CourseVote.cshtml"
                      Write(Model.Item2);

#line default
#line hidden
            EndContext();
            BeginContext(597, 47, true);
            WriteLiteral(")\r\n            </a>\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 21 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\CourseVote.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<int,int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
