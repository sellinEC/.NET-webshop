#pragma checksum "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20032478637b8fc91801312dbcf5bc6c3d53392"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/{id}")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Welcome to categories</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container d-flex justify-content-center");
#nullable restore
#line 8 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
     if (categories == null)
    {



#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Loading... ");
            __builder.AddContent(5, 
#nullable restore
#line 12 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
                       Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
    }
    else
    {
        foreach (var cat in categories)
        {
            if (cat.Id == Int32.Parse(Id))
            {
                if (cat.Products.Count > 0)
                {
                    foreach (var product in cat.Products)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorFrontend.Shared.ProductItem>(6);
            __builder.AddAttribute(7, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFrontend.Models.Product>(
#nullable restore
#line 24 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
                                            product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"


                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p>Empty category</p>");
#nullable restore
#line 32 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
                }


            }
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Category[] categories;
    private async Task GetCategoriesAsync()
    {
        categories = await Http.GetFromJsonAsync<Category[]>("https://localhost:44398/api/Categories");

        StateHasChanged();

        foreach (var item in categories)
        {
            Console.WriteLine(item.ToString());
        }

    }
    protected override async void OnInitialized()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Pages\Categories.razor"
                                       
        await GetCategoriesAsync();

    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
