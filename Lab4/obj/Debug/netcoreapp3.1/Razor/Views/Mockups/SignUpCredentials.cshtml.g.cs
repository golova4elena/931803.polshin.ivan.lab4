#pragma checksum "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0aacd539d4e76deb50ee38f4222cf387a8338e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_SignUpCredentials), @"mvc.1.0.view", @"/Views/Mockups/SignUpCredentials.cshtml")]
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
#line 1 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0aacd539d4e76deb50ee38f4222cf387a8338e", @"/Views/Mockups/SignUpCredentials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dc5fb44c3021da35399707c52c994f788c9f72", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_SignUpCredentials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
  
    ViewData["Title"] = "Sign up result";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-left\">\n        <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        First Name : ");
#nullable restore
#line 7 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
                Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Last Name : ");
#nullable restore
#line 8 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Bithday : ");
#nullable restore
#line 9 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
             Write(Model.BDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
                         Write(Model.BMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
                                       Write(Model.BYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Gender : ");
#nullable restore
#line 10 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
            Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Email : ");
#nullable restore
#line 11 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Password : ");
#nullable restore
#line 12 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
              Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        Remember : ");
#nullable restore
#line 13 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
              Write(Model.Remember);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n        YourResetCode : ");
#nullable restore
#line 14 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUpCredentials.cshtml"
                   Write(Model.ResetCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountData> Html { get; private set; }
    }
}
#pragma warning restore 1591
