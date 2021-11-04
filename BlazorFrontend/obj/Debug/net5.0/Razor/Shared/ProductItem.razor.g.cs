#pragma checksum "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fe3d238808ee3ea36b66cd2b13eba91b5e96fb4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontend.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using BlazorFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using BlazorFrontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using BlazorFrontend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "href", 
#nullable restore
#line 1 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
                Href

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "list-group-item list-group-item-action");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "d-flex w-100 justify-content-between");
                __builder2.OpenElement(6, "h5");
                __builder2.AddAttribute(7, "class", "mb-1");
                __builder2.AddContent(8, 
#nullable restore
#line 3 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
                          Item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "img");
                __builder2.AddAttribute(11, "src", 
#nullable restore
#line 5 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
               Item.ImgUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "alt", 
#nullable restore
#line 5 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
                                  Item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenElement(14, "p");
                __builder2.AddAttribute(15, "class", "mb-1");
                __builder2.AddContent(16, 
#nullable restore
#line 6 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
                     Item.ShortDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "p");
                __builder2.AddAttribute(19, "class", "mb-1");
                __builder2.AddContent(20, 
#nullable restore
#line 7 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
                     Item.LongDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenElement(22, "small");
                __builder2.AddContent(23, 
#nullable restore
#line 8 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
            Item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\ProductItem.razor"
       
    [Parameter]
    public Product Item { get; set; }
    public string Href { get; set; }


    protected override void OnInitialized()
    {
        Href = "product/" + Item.Id.ToString();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
