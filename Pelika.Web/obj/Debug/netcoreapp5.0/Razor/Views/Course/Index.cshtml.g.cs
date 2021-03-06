#pragma checksum "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5581b4461b2d1b034d9e1e9c6581dc81ed617c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
using Pelika.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
using Pelika.DataLayer.Entities.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5581b4461b2d1b034d9e1e9c6581dc81ed617c", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Pelika.Core.DTOs.Course.ShowCourseListItemViewModel>, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

    List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
    List<int> selected = ViewBag.selectedGroups as List<int>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">??????????</a></li>
            <li class=""breadcrumb-item active""><a href=""/Course"">???????? ????</a></li>
        </ul>
    </nav>
</div>

<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5581b4461b2d1b034d9e1e9c6581dc81ed617c6118", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 760, "\"", 794, 1);
#nullable restore
#line 25 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 768, ViewBag.pageId.ToString(), 768, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <section class=\"term-categories\">\r\n\r\n            <div class=\"top-bar\">\r\n\r\n                <header>\r\n                    <h1> ???????? ?????? <span style=\"color: #95a5a6\"> ???????????? ?????????? </span> </h1> <span>");
#nullable restore
#line 31 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                            Write(ViewBag.CourseCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ???????? </span>
                </header>

                <div class=""row"">

                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">

                        <input type=""text"" name=""filter"" placeholder=""?????????? ???????? ?????? ..."">
                        <button><i class=""zmdi zmdi-search""></i></button>

                    </div>

                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""getType"" value=""all""");
                BeginWriteAttribute("checked", " checked=\"", 1603, "\"", 1613, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                            <label for=""available-filter-1""> ?????? </label>
                            <input id=""available-filter-2"" name=""getType"" value=""buy"" type=""radio"">
                            <label for=""available-filter-2""> ???????????? </label>
                            <input id=""available-filter-3"" name=""getType"" value=""free"" type=""radio"">
                            <label for=""available-filter-3""> ???????????? </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderByType"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5581b4461b2d1b034d9e1e9c6581dc81ed617c8874", async() => {
                    WriteLiteral(" ?????????? ???????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5581b4461b2d1b034d9e1e9c6581dc81ed617c10137", async() => {
                    WriteLiteral(" ?????????? ???????? ?????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>

            </div>

            <div class=""row"">

                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> ?????????? ???? ???????? ???????? </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3019, "\"", 3027, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startPrice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3112, "\"", 3120, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""max-price"">???? <span id=""max-text"">500000</span> ??????????</div>
                            <div class=""min-price"">???? <span id=""min-text"">20000</span> ??????????</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> ???????? ???????? ?????????????? </h3>
                        </header>
                        <div class=""inner"">

                            <ul>
");
#nullable restore
#line 92 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                 foreach (var group in groups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input onchange=\"changeGroup()\" type=\"checkbox\" ");
#nullable restore
#line 95 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == group.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"selectedGroups\" value=\"");
#nullable restore
#line 95 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                                                                                                            Write(group.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
#nullable restore
#line 96 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                       Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 97 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                         if (groups.Any(g => g.ParentId == group.GroupId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <ul>\r\n");
#nullable restore
#line 100 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                 foreach (var sub in groups.Where(g => g.ParentId == group.GroupId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input onchange=\"changeGroup()\" ");
#nullable restore
#line 103 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == sub.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 103 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                                                                                                                          Write(sub.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                                        <label for=\"cat-1\"> ");
#nullable restore
#line 104 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                       Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                                    </li>\r\n");
#nullable restore
#line 106 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n");
#nullable restore
#line 108 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 111 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>

                </aside>

                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">

                    <section class=""terms-items"">
                        <div class=""row"">
");
#nullable restore
#line 122 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f5581b4461b2d1b034d9e1e9c6581dc81ed617c18319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 124 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 125 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n\r\n");
#nullable restore
#line 129 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                         if (Model.Item2 > 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <nav aria-label=\"Page navigation\">\r\n                                <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 134 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                     for (int i = 1; i <= (int)Model.Item2; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6349, "\"", 6373, 3);
                WriteAttributeValue("", 6359, "changePage(", 6359, 11, true);
#nullable restore
#line 136 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 6370, i, 6370, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6372, ")", 6372, 1, true);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">");
#nullable restore
#line 136 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                                                                                                                Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 137 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </nav>\r\n");
#nullable restore
#line 141 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Course\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </section>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""/css/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [20000, 100000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 100000
                }
            });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xval");
                WriteLiteral(@"ue;
                } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(values[handle]);
            });

            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });


            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });



            function updateSliderRange(min, max) {
                slider.noUiSl");
                WriteLiteral(@"ider.updateOptions({
                    range: {
                        'min': min,
                        'max': max
                    }
                });
            }
        });

        function changeGroup() {
            $(""#formFilter"").submit();
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Pelika.Core.DTOs.Course.ShowCourseListItemViewModel>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
