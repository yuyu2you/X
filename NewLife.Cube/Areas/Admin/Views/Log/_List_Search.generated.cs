﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Log/_List_Search.cshtml")]
    public partial class _Areas_Admin_Views_Log__List_Search_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Log__List_Search_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"category\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">类别：</label>\r\n");

WriteLiteral("    ");

            
            #line 3 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.ForDropDownList("category", Log.FindAllCategoryName(), Request["category"], "全部", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"userid\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">用户：</label>\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.ForDropDownList("userid", UserX.FindAllWithCache().Cast<IEntity>().ToList(), "全部", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 9 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.Partial("_DateRange"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
