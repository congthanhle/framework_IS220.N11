#pragma checksum "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonDatHang\DatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c7a57fa92b5c364cda2082d9ae290b9f75683e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonDatHang_DatHang), @"mvc.1.0.view", @"/Views/DonDatHang/DatHang.cshtml")]
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
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonDatHang\DatHang.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c7a57fa92b5c364cda2082d9ae290b9f75683e", @"/Views/DonDatHang/DatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DonDatHang_DatHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonDatHang\DatHang.cshtml"
  
    ViewData["Title"] = "Thanh toán";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonDatHang\DatHang.cshtml"
  
    var madh = ViewData["MADDH"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content pb-5"">
    <div class=""breadcrumb-area m-4"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <ul>
                            <li>
                                <a href=""index.html"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Thanh toán</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <h4 class=""text-center p-100"" style=""height:50px"">Đặt hàng thành công. Mã đơn hàng của bạn là: ");
#nullable restore
#line 29 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonDatHang\DatHang.cshtml"
                                                                                                  Write(madh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4 class=\"text-center p-100\" style=\"height:50px\">Cảm ơn bạn đã mua hàng!</h4>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591