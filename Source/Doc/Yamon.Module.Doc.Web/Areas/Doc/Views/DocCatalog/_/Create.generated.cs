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
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Doc/Views/DocCatalog/_/Create.cshtml")]
    public partial class _Areas_Doc_Views_DocCatalog___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Doc_Views_DocCatalog___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
  
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
    ViewBag.Title="新建公文类型";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Doc/DocCatalog/Create\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_ParentID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ParentID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">上级类型：</td><td>&nbsp;\r\n\r\n<input");

WriteLiteral(" id=\"ParentID\"");

WriteLiteral(" name=\"ParentID\"");

WriteAttribute("url", Tuple.Create(" url=\"", 840), Tuple.Create("\"", 909)
, Tuple.Create(Tuple.Create("", 846), Tuple.Create("/api/Doc/DocCatalog/EditTree?&iscombo=1&Value=", 846), true)
            
            #line 22 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
          , Tuple.Create(Tuple.Create("", 892), Tuple.Create<System.Object, System.Int32>(Model.ParentID
            
            #line default
            #line hidden
, 892), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 910), Tuple.Create("\"", 935)
            
            #line 22 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
                                    , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(Model.ParentID
            
            #line default
            #line hidden
, 918), false)
);

WriteLiteral(" style=\"width: 200px\"");

WriteLiteral(" />\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var ParentID_Value = \'");

            
            #line 24 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
                      Write(Model.ParentID);

            
            #line default
            #line hidden
WriteLiteral(@"';
    jQuery(function() {
        jQuery('#ParentID').combotree(
        {
            onLoadSuccess:function(node, data) {
                jQuery('#ParentID').combotree('setValue',ParentID_Value);
            }
        });
    });
</script>
</td></tr>
<tr");

WriteLiteral(" id=\"Container_CatalogName\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CatalogName\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">栏目名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CatalogName\"");

WriteLiteral(" name=\"CatalogName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1453), Tuple.Create("\"", 1481)
            
            #line 36 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1461), Tuple.Create<System.Object, System.Int32>(Model.CatalogName
            
            #line default
            #line hidden
, 1461), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_OrderID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(" name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1703), Tuple.Create("\"", 1727)
            
            #line 39 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1711), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 1711), false)
);

WriteLiteral(" class=\"easyui-numberbox\"");

WriteLiteral(" min=\"0\"");

WriteLiteral(" max=\"10000000\"");

WriteLiteral("  style=\"width:200px;\"");

WriteLiteral("/>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Remark\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Remark\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备注：</td><td>&nbsp;\r\n<textarea");

WriteLiteral(" id=\"Remark\"");

WriteLiteral(" name=\"Remark\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:90%;height:80px\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
                                                                                          Write(Model.Remark);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td></tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 47 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
   Write(RenderPage("~/Areas/Doc/Views/DocCatalog/Extend/Model_FormHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-ok\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">确定</a>\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        取消\r\n    </a>\r\n</div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Utils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        jQuery(function() {
            CheckConditions();
function CheckConditions(){
jQuery('fieldset').show(); 
jQuery(""fieldset"").each(function(){ 
if(jQuery('tr',this).length>0){
if(jQuery('tr:visible',this).length>0){jQuery(this).show()} else{jQuery(this).hide()}
}
});
}
;
        });
    </script>
");

WriteLiteral("    ");

            
            #line 75 "..\..\Areas\Doc\Views\DocCatalog\_\Create.cshtml"
Write(RenderPage("~/Areas/Doc/Views/DocCatalog/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
