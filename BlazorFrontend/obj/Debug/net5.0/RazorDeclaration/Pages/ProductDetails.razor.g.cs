// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorFrontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#nullable restore
#line 13 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
       
    [Parameter]
    public string Id { get; set; }
    private CartItem cartItem = new CartItem { Quantity = 1 };

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                                                       
    public Product Item { get; set; } = new();


    protected override async Task OnInitializedAsync()
    {
        Item = await Http.GetFromJsonAsync<Product>($"https://localhost:44398/api/Products/{Id}");
    }

   

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\ProductDetails.razor"
                                 

private async Task AddToCart()
{
    var cart = await LocalStorage.GetItemAsync<List<CartItem>>("cart");
    if (cart == null)
    {
        cart = new List<CartItem>();
    }
    //Kollar om l??gga till mer quantity beroende p?? om redan finns
    var itemExists = cart.Find(x => x.ProductId == Item.Id);
    if (itemExists == null)
    {
        cartItem.ProductName = Item.ProductName;
        cartItem.ProductId = Item.Id;
        cartItem.ImgUrl = Item.ImgUrl;
        cartItem.Price = Item.Price;
        cart.Add(cartItem);
    }
    else
    {
        itemExists.Quantity += cartItem.Quantity;
    }

    await LocalStorage.SetItemAsync("cart", cart);
    ToastService.ShowSuccess(Item.ProductName, "Added to cart");
    
   

}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
