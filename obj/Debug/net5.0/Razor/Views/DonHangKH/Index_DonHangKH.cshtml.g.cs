#pragma checksum "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c44395254a4bb5d4b1fb3933a3f417d0ca62cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHangKH_Index_DonHangKH), @"mvc.1.0.view", @"/Views/DonHangKH/Index_DonHangKH.cshtml")]
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
#line 2 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c44395254a4bb5d4b1fb3933a3f417d0ca62cf2", @"/Views/DonHangKH/Index_DonHangKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DonHangKH_Index_DonHangKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
  
    ViewData["Title"] = "Đơn hàng của bạn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
  
    List<GioHang> list_item = (List<GioHang>)ViewBag.donDH;
    int madh = ViewBag.madh;
    Dondathang ddh = ViewBag.ddh;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-5\">\r\n    <div class=\"your-order\">\r\n        <h3>Đơn hàng của bạn: ");
#nullable restore
#line 13 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                         Write(madh);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
        <div class=""your-order-table table-responsive"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th class=""cart-product-name"">Sản phẩm</th>
                        <th class=""cart-product-total"">Tổng tiền</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                      
                        var tongtien = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                     foreach (var item in list_item)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"cart_item\">\r\n                            <td class=\"cart-product-name\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                           Write(item.sanpham.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"product-quantity\"> × ");
#nullable restore
#line 30 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                                                                                   Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </td>\r\n");
#nullable restore
#line 32 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                              
                                var sump = @item.Soluong * @item.sanpham.GiaTien;
                                tongtien += Convert.ToInt32(sump);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"cart-product-total\"><span class=\"amount\">");
#nullable restore
#line 36 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                                                                           Write(sump.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr class=\"cart-subtotal\">\r\n                        <th>Thành tiền</th>\r\n                        <td><span class=\"amount\">");
#nullable restore
#line 43 "C:\Users\TRAN VAN QUANG\source\repos\PhamNhuLong-Web_Decorate_Stis\Views\DonHangKH\Index_DonHangKH.cshtml"
                                            Write(tongtien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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