﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    #line 24 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 25 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Yamon.Framework.Common;
    using Yamon.Module.SiteManage.Entity;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Doc/Views/DocInformationView/_/Grid1.cshtml")]
    public partial class _Areas_Doc_Views_DocInformationView___Grid1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Doc_Views_DocInformationView___Grid1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 3 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
  
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的内容，请复制一份到此文件的上级目录进行修改
//
//     如有问题联系zongeasy@qq.com
//</auto-generated>
//------------------------------------------------------------------------------

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"tt\"");

WriteLiteral("></div>\r\n");

            
            #line 17 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
Write(RenderPage("~/Areas/Doc/Views/DocInformationView/Extend/Model_GridHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"toolbar\"");

WriteLiteral(" style=\"padding: 5px; height: auto\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"searchForm\"");

WriteLiteral(" name=\"searchForm\"");

WriteLiteral(" action=\"\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 715), Tuple.Create("\"", 737)
            
            #line 22 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
, Tuple.Create(Tuple.Create("", 720), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 720), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 764), Tuple.Create("\"", 791)
            
            #line 22 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
             , Tuple.Create(Tuple.Create("", 774), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 774), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 805), Tuple.Create("\"", 879)
, Tuple.Create(Tuple.Create("", 815), Tuple.Create("T_", 815), true)
            
            #line 22 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 817), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 817), false)
, Tuple.Create(Tuple.Create("", 850), Tuple.Create("ClickHandler();return", 850), true)
, Tuple.Create(Tuple.Create(" ", 871), Tuple.Create("false;", 872), true)
, Tuple.Create(Tuple.Create(" ", 878), Tuple.Create("", 878), true)
);

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 31 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 32 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 35 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("\r\n        <span");

WriteLiteral(" id=\"span_CatalogID\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">类型：\r\n<input");

WriteLiteral(" id=\"CatalogID\"");

WriteLiteral(" name=\"CatalogID\"");

WriteAttribute("url", Tuple.Create(" url=\"", 1355), Tuple.Create("\"", 1395)
            
            #line 40 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
, Tuple.Create(Tuple.Create("", 1361), Tuple.Create<System.Object, System.Int32>(ViewBag.DAL.NameValue_CatalogID
            
            #line default
            #line hidden
, 1361), false)
);

WriteLiteral("  style=\"width:200px;\"");

WriteLiteral(" multiple=\"true\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" cascadeCheck=\"true\"");

WriteLiteral(" onlyLeafCheck=\"true\"");

WriteLiteral(">\r\n</span>\r\n<span");

WriteLiteral(" id=\"span_InfoNo\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">文档编号：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"InfoNo\"");

WriteLiteral(" name=\"InfoNo\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_Title\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">标题：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_HtmlContent\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">内容：<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"HtmlContent\"");

WriteLiteral(" name=\"HtmlContent\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1980), Tuple.Create("\"", 2029)
            
            #line 44 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(RequestHelper.GetString("HtmlContent")
            
            #line default
            #line hidden
, 1988), false)
);

WriteLiteral(" style=\"width:100px\"");

WriteLiteral("/></span>\r\n\r\n            <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-search\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">查询</a>\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" id=\"PagerButtons\"");

WriteLiteral("><label><input");

WriteLiteral(" id=\"BatchCheck\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" />多选</label></div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        var _baseUrl = '/Doc/DocInformationView';
var _apiUrl = '/api/Doc/DocInformationView';
var _pageUrl = '';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: '',
DataUrl: _apiUrl + '/Grid1?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'Doc',
ModelID: 'DocInformationView',
PageSize: 20,
DialogWidth: 800,
DialogHeight: 600,
FieldShowType_Name_FieldName: '',
TreeField: '',
FieldShowType_Name_Title: '',
ItemName: ""文档"",
PrimaryKey: 'InfoID',
SortField: 'ID',
OrderType: 'desc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 79 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 81 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 85 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 85 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 85 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 86 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 88 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'InfoID', title: '文档编号', sortable: true,width:100,hidden:true,align:'left'},
{field: 'CatalogID_ShowValue', title: '类型', sortable: true,width:100,align:'left'},
{field: 'InfoNo', title: '文档编号', sortable: true,width:200,align:'left'},
{field: 'Title', title: '标题', sortable: true,align:'left'},
{field: 'CreateTime', title: '创建时间', sortable: true,width:130,align:'left'},
{field: 'CreateUserID_ShowValue', title: '创建人', sortable: true,width:120,align:'left'},
{field: 'InfoType_ShowValue', title: '信息类型', sortable: true,width:100,align:'left'}
");

            
            #line 98 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 102 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 102 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 102 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 103 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 105 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 117 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
          Write(RequestHelper.GetBool("SingleSelect",true).ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\r\n}\r\n    </script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.query.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/GridUtils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/SmartFormGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Grid.js\"");

WriteLiteral("></script>\r\n");

            
            #line 125 "..\..\Areas\Doc\Views\DocInformationView\_\Grid1.cshtml"
Write(RenderPage("~/Areas/Doc/Views/DocInformationView/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591