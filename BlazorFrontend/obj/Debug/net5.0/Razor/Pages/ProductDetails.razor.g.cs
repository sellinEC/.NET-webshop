#pragma checksum "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b74598d804aede1d9bcf3275d02d4a9fc312df6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontend.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex justify-content-center align-items-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "m-4 card p-2 ");
            __builder.AddAttribute(6, "style", "height : 20rem");
            __builder.OpenElement(7, "h2");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                 Item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "mt-2");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                             Item.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 9 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                Item.LongDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class");
            __builder.OpenElement(19, "h4");
            __builder.AddContent(20, 
#nullable restore
#line 11 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                     Item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                 if (Item.InStock)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<span><i class=\"fas fa-cubes text-success font-weight-bold\"></i></span>");
#nullable restore
#line 18 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<span><i class=\"fas fa-cubes text-danger font-weight-bold\"></i></span>");
#nullable restore
#line 24 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        \r\n        ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 29 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                   Item.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "alt", "Alternate Text");
            __builder.AddAttribute(27, "style", "height: 20rem");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.AddMarkupContent(29, "<button class=\"btn btn-secondary\">ADD TO CART</button>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
       
    [Parameter]
    public string Id { get; set; }

    public Product Item { get; set; } = new();


    protected override async Task OnInitializedAsync()
    {
        Item = await Http.GetFromJsonAsync<Product>($"https://localhost:44398/api/Products/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
