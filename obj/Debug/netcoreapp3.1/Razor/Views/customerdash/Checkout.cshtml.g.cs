#pragma checksum "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\customerdash\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269ae8f4c008bfb0c2a33c5f8867efdf19c4ea8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_customerdash_Checkout), @"mvc.1.0.view", @"/Views/customerdash/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269ae8f4c008bfb0c2a33c5f8867efdf19c4ea8f", @"/Views/customerdash/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2adaf7ecdb025b988a332a49a67907d6a5f5063", @"/Views/_ViewImports.cshtml")]
    public class Views_customerdash_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <main>
        <div class=""py-5 text-center"">
            <h2>Checkout form</h2>
            <p class=""lead""> Cash on Delivery available. Please visit for more offers! </p>
        </div>
        <br>
        <h2> <strong>Your Pay is: &#x20B9 ");
#nullable restore
#line 8 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\customerdash\Checkout.cshtml"
                                     Write(ViewBag.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong> </h2>
        <br>
        <div class=""row g-5"">
            <div class=""col-md-7 col-lg-8"">
                <h4 class=""mb-3"">Billing address</h4>
                <div class=""row g-3"">
                    <div class=""col-sm-6"">
                        <label for=""firstName"" class=""form-label"">First name</label>
                        <input type=""text"" class=""form-control"" id=""firstName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 701, "\"", 715, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 716, "\"", 724, 0);
            EndWriteAttribute();
            WriteLiteral(@" required>
                        <div class=""invalid-feedback"">
                            Valid first name is required.
                        </div>
                    </div>

                    <div class=""col-sm-6"">
                        <label for=""lastName"" class=""form-label"">Last name</label>
                        <input type=""text"" class=""form-control"" id=""lastName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1119, "\"", 1133, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1134, "\"", 1142, 0);
            EndWriteAttribute();
            WriteLiteral(@" required>
                        <div class=""invalid-feedback"">
                            Valid last name is required.
                        </div>
                    </div>

                    <div class=""col-12"">
                        <label for=""email"" class=""form-label"">Email <span class=""text-muted"">(Optional)</span></label>
                        <input type=""email"" class=""form-control"" id=""email"" placeholder=""you@example.com"">
                        <div class=""invalid-feedback"">
                            Please enter a valid email address for shipping updates.
                        </div>
                    </div>

                    <div class=""col-12"">
                        <label for=""address"" class=""form-label"">Address</label>
                        <input type=""text"" class=""form-control"" id=""address"" placeholder=""1234 Main St"" required>
                        <div class=""invalid-feedback"">
                            Please enter your shipping address.
   ");
            WriteLiteral("                     </div>\r\n                    </div>\r\n\r\n                    <hr />\r\n                    <hr class=\"my-4\">\r\n                    <br />\r\n                    <hr />\r\n                    <button class=\"w-20 btn btn-primary btn-lg\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2412, "\"", 2485, 3);
            WriteAttributeValue("", 2422, "location.href=\'", 2422, 15, true);
#nullable restore
#line 50 "C:\Users\11035905\source\repos\phase3proj\phase3proj\Views\customerdash\Checkout.cshtml"
WriteAttributeValue("", 2437, Url.Action("success", "customerdash", new { }), 2437, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2484, "\'", 2484, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Checkout Here</button>\r\n\r\n                </div>\r\n            </div>\r\n    </main>\r\n</div>");
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
