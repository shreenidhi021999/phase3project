#pragma checksum "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4727436b301cd67e5ca44b6f58e31e71978604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Dashboard), @"mvc.1.0.view", @"/Views/Admins/Dashboard.cshtml")]
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
#line 1 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\_ViewImports.cshtml"
using phase3proj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\_ViewImports.cshtml"
using phase3proj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4727436b301cd67e5ca44b6f58e31e71978604", @"/Views/Admins/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2adaf7ecdb025b988a332a49a67907d6a5f5063", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 style=\"color:firebrick;font-family:Calibri\">Welcome  <b>");
#nullable restore
#line 1 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
                                                       Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n\r\n<div style=\"min-height:30vh;\">\r\n    <div class=\"mt-5\" style=\"display:flex;justify-content:center;align-items:center;flex-direction:column\">\r\n        <p>Total Number of Registered Sellers: <b>");
#nullable restore
#line 5 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
                                             Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n        <p>Total Number of Registered Customers: <b>");
#nullable restore
#line 6 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
                                               Write(ViewBag.c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n        <p>Total Number of Laptops for sale: <b>");
#nullable restore
#line 7 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
                                           Write(ViewBag.l);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n    </div>\r\n\r\n    <div class=\"mt-10\" style=\"display:flex;justify-content:center;align-items:center;flex-direction:row\">\r\n        <button style=\"margin:0px 10px; background:red\" class=\"w-20 btn btn-primary btn-lg\"");
            BeginWriteAttribute("onclick", " onclick=\"", 649, "\"", 715, 3);
            WriteAttributeValue("", 659, "location.href=\'", 659, 15, true);
#nullable restore
#line 11 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
WriteAttributeValue("", 674, Url.Action("index", "sellers", new { }), 674, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 714, "\'", 714, 1, true);
            EndWriteAttribute();
            WriteLiteral("><b>View Registered sellers</b></button><br/>\r\n        <button style=\"margin: 0px 10px; background:brown\" class=\"w-20 btn btn-primary btn-lg\"");
            BeginWriteAttribute("onclick", " onclick=\"", 857, "\"", 925, 3);
            WriteAttributeValue("", 867, "location.href=\'", 867, 15, true);
#nullable restore
#line 12 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
WriteAttributeValue("", 882, Url.Action("index", "customers", new { }), 882, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 924, "\'", 924, 1, true);
            EndWriteAttribute();
            WriteLiteral("><b>View Registered Customers</b></button> </br>\r\n        <button style=\"margin: 0px 10px; \" class=\"w-20 btn btn-primary btn-lg\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1054, "\"", 1126, 3);
            WriteAttributeValue("", 1064, "location.href=\'", 1064, 15, true);
#nullable restore
#line 13 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\Admins\Dashboard.cshtml"
WriteAttributeValue("", 1079, Url.Action("index", "laptopdetails", new { }), 1079, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1125, "\'", 1125, 1, true);
            EndWriteAttribute();
            WriteLiteral("><b>View Products</b></button> </br>\r\n    </div>\r\n</div>");
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
