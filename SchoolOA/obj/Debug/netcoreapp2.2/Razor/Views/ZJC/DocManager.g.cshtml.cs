#pragma checksum "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\ZJC\DocManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee1cdfb416ea225de54f40e736f3013f168aa8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ZJC_DocManager), @"mvc.1.0.view", @"/Views/ZJC/DocManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ZJC/DocManager.cshtml", typeof(AspNetCore.Views_ZJC_DocManager))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee1cdfb416ea225de54f40e736f3013f168aa8c", @"/Views/ZJC/DocManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cd7af7bea814cbe691151fb0f76259a8959969", @"/Views/_ViewImports.cshtml")]
    public class Views_ZJC_DocManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui-v2.5.5/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\Xauat-Computer\生产实习\SchoolOA\SchoolOA\Views\ZJC\DocManager.cshtml"
  
    Layout = "_ZjcLayout";
    ViewData["Title"] = "政教处";

#line default
#line hidden
            BeginContext(67, 1967, true);
            WriteLiteral(@"
<div class=""layui-container"">
    <fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
        <legend>文件审核</legend>
    </fieldset>

    <div class=""layui-row"">
        物资申请表
        <div class=""demoTable"">
            搜索审核状态：
            <div class=""layui-inline"">
                <input class=""layui-input"" name=""keyword"" id=""demoReload"" autocomplete=""off"">
            </div>
            <button class=""layui-btn"" data-type=""reload"">搜索</button>
        </div>
        <div class=""demoTable"">
            输入所在部门：
            <div class=""layui-inline"">
                <input class=""layui-input"" name=""keyword"" id=""demoReload2"" autocomplete=""off"">
            </div>
            <button class=""layui-btn"" data-type=""reload"">搜索</button>
        </div>
        <table class=""layui-hide"" id=""materialApply"" lay-filter=""material"" ></table>
        <script type=""text/html"" id=""barDemo"">
            <a class=""layui-btn layui-btn-primary layui-btn-mini"" lay-event=""detail"">查看");
            WriteLiteral(@"</a>
            <a class=""layui-btn layui-btn-mini"" lay-event=""edit"">编辑</a>
            <a class=""layui-btn layui-btn-danger layui-btn-mini"" lay-event=""del"">删除</a>
        </script>
        会议申请表
        <div class=""demoTable"">
            搜索审核状态：
            <div class=""layui-inline"">
                <input class=""layui-input"" name=""keyword"" id=""demoReload1"" autocomplete=""off"">
            </div>
            <button class=""layui-btn"" data-type=""reload"">搜索</button>
        </div>

        <table class=""layui-hide"" id=""conventionApply"" lay-filter=""conventionApply""></table>
        <script type=""text/html"" id=""barDemo1"">
            <a class=""layui-btn layui-btn-primary layui-btn-mini"" lay-event=""detail"">查看</a>
            <a class=""layui-btn layui-btn-mini"" lay-event=""edit"">编辑</a>
            <a class=""layui-btn layui-btn-danger layui-btn-mini"" lay-event=""del"">删除</a>
        </script>


    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2051, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2057, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee1cdfb416ea225de54f40e736f3013f168aa8c6698", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2126, 53, true);
                WriteLiteral("\r\n    <!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->\r\n    ");
                EndContext();
                BeginContext(2179, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee1cdfb416ea225de54f40e736f3013f168aa8c8090", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2217, 975, true);
                WriteLiteral(@"
    <script>
        layui.use('table', function () {
            var table = layui.table;

            table.render({
                elem: '#materialApply'
                , url: '/Api/QueryAllMaterialApply'
                , cols: [[
                     { field: 'id', width: ""5%"", title: '编号', sort: true }
                    , { field: 'teacherName', width: ""10%"", title: '申请人名称' }
                    , { field: 'sectionName', title: '申请人所在部门', width: ""10%""}
                    , { field: 'goodsName', width: ""10%"", title: '物资名称' }
                    , { field: 'goodsNum', width: ""10%"", title: '物资数量' }
                    , { field: 'goodsPrice', width: ""10%"", title: '物资单价' }
                    , { field: 'remarks', width: ""10%"", title: '备注（申请理由等说明）' }
                    , { field: 'state', width: ""10%"", title: '当前状态' }

                ]]
                , page: true
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
