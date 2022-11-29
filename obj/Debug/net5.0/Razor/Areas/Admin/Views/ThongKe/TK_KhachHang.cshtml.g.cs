#pragma checksum "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8beaf58aa93122e21111198bd2128eea9f6885dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_TK_KhachHang), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/TK_KhachHang.cshtml")]
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
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8beaf58aa93122e21111198bd2128eea9f6885dc", @"/Areas/Admin/Views/ThongKe/TK_KhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06652b0cc81f2d191b5af8090e20dd00b01c0e55", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ThongKe_TK_KhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
  
    ViewData["Title"] = "Thống kê loại khách hàng";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
  
    var list_kh = (SortedList<string, int>)ViewBag.ListKH; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   -
<div class=""card"">
    <div class=""card-body"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h5>Thống kê loại khách hàng </h5>

        </div>
        <div class=""m-t-30"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Loại khách hàng</th>
                            <th>Số lượng</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
                         if (list_kh != null)
                        {
                            foreach (var item in list_kh)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 35 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
                                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
                                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Areas\Admin\Views\ThongKe\TK_KhachHang.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
