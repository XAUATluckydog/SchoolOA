#pragma checksum "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba79b13d68d3f64ebcbbf80275d4bca0a8ecaf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\_ViewImports.cshtml"
using SchoolOA;

#line default
#line hidden
#line 2 "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\_ViewImports.cshtml"
using SchoolOA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba79b13d68d3f64ebcbbf80275d4bca0a8ecaf0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cd7af7bea814cbe691151fb0f76259a8959969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui-v2.5.5/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\Home\Index.cshtml"
  
    Layout = "_IndexLayout";
    ViewData["Title"] = "Home Page";
    var titles = ViewData["Title"];

#line default
#line hidden
            BeginContext(112, 1918, true);
            WriteLiteral(@"<!-- Hero Section -->
<section class=""section section-hero"">
    <div class=""hero-box"">
        <div class=""container"">
            <div class=""hero-text align-center"">
                <h1>西安建筑科技大学附属中学</h1>
                <p>校内办公系统</p>
            </div>
        </div>
    </div>

    <!-- Statistics Box -->
    <div class=""container"">
        <div class=""statistics-box"">
            <div class=""statistics-item"">
                <span class=""value"">2,300</span>
                <p class=""title"">近期会议安排</p>
            </div>

            <div class=""statistics-item"">
                <span class=""value"">1,000</span>
                <p class=""title"">奖惩情况</p>
            </div>

            <div class=""statistics-item"">
                <span class=""value"">35,000</span>
                <p class=""title"">学生人数</p>
            </div>

            <div class=""statistics-item"">
                <span class=""value"">50,000</span>
                <p class=""title"">教师人数</p>
            </div>
");
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- Destinations Section -->
<section class=""section section-destination"">
    <!-- Title -->
    <div class=""section-title"">
        <div class=""container"">
            <h1 class=""title"">近期会议安排</h1>
        </div>
    </div>
    <div class=""container"">
        <table class=""layui-hide"" id=""conventionTable"" align=""center""></table>
    </div>

</section>

<!-- Parallax Box -->
<div class=""parallax-box"">
    <div class=""container"">
        <div class=""text align-center"">

                <p id=""hitokoto"">:D 获取中...</p>
        </div>
    </div>
</div>

<!-- Boats Section -->
<section class=""section section-boats"">
    <!-- Title -->
    <div class=""section-title"">
        <div class=""container"">
            <h class=""title"">学生奖惩公告</h>
        </div>
    </div>

    <!-- Content -->
    <div class=""container"">
");
            EndContext();
            BeginContext(2115, 115, true);
            WriteLiteral("        <table class=\"layui-hide\" id=\"awardPunishTable\" lay-filter=\"demoEvent\"></table>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2247, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2255, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba79b13d68d3f64ebcbbf80275d4bca0a8ecaf06169", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2308, 2441, true);
                WriteLiteral(@"
    <script src=""https://v1.hitokoto.cn/?encode=js&select=%23hitokoto"" defer></script>
    <script>
        layui.use('table', function () {
            var table = layui.table;
            table.render({
                elem: '#conventionTable'
                , url: '/Api/GetConventionApply'
                , height: 475
                , cols: [[
                    { field: 'id', width: 80, title: '编号', sort: true }
                    , { field: 'proposerName', width: 120, title: '申请人' }
                    , { field: 'proposerSection', width: 140, title: '申请人所在部门' }
                    , { field: 'proposerPhone', width: 140, title: '申请人联系方式' }
                    , { field: 'startTime', width: 200, title: '开始时间', sort: true }
                    , { field: 'endTime', width: 200, title: '结束时间' }
                    , { field: 'place', width: 150, title: '会议地点' }
                    , { field: 'currentState', title: '当前状态', Width: 150 }
                ]]
                , page: true
");
                WriteLiteral(@"                , skin: 'line' //行边框风格
                , even: true //开启隔行背景
            });
        });
    </script>
    <script>
        layui.use('table', function () {
            var table = layui.table;
            table.render({
                elem: '#awardPunishTable'
                , url: '/Api/AwardPunishList'
                , cols: [[
                    { field: 'id', width: ""10%"", title: '编号', sort: true, event: 'setSign', style: 'cursor: pointer;' }
                    , { field: 'title', width: ""30%"", title: '标题' }
                    , { field: 'applyTime', width: ""20%"", title: '申请时间', sort: true }
                    , { field: 'checkTime', width: ""20%"", title: '审核时间' }
                    , { field: 'state', width: ""20%"", title: '审核状态' }
                ]]
                , page: true
                , skin: 'line' //行边框风格
                , even: true //开启隔行背景
            });

            //监听单元格事件
            table.on('tool(demoEvent)', function (obj) {
        ");
                WriteLiteral(@"        var data = obj.data;
                if (obj.event === 'setSign') {
                    layer.open({
                        type: 2,
                        area: ['500px', '570px'],
                        title: '奖惩详细信息',
                        content: '/Home/APDetail?id=' + data.id
                    });
                }
            });
        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591