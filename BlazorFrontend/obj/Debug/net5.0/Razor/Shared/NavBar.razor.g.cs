#pragma checksum "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f64f9ac557b794b5935a90956c5a5165a68b5b"
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
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light shadow");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "class", "navbar-brand");
            __builder.AddAttribute(6, "href", "");
            __builder.AddAttribute(7, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<i class=\"fas fa-shopping-cart me-2\"></i>\r\n            ECart\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<button class=\"navbar-toggler\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#navbar\" aria-controls=\"navbar\" aria-expanded=\"false\" aria-label=\"Toggle navigation\"><span class=\"navbar-toggler-icon\"></span></button>\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "collapse navbar-collapse");
            __builder.AddAttribute(14, "id", "navbar");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "navbar-nav");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "nav-link");
            __builder.AddAttribute(19, "href", "");
            __builder.AddAttribute(20, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(22, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-item dropdown");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "<a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n                        Categories\r\n                    </a>\r\n                    ");
                __builder2.OpenElement(28, "ul");
                __builder2.AddAttribute(29, "class", "dropdown-menu");
                __builder2.AddAttribute(30, "aria-labelledby", "navbarDropdown");
#nullable restore
#line 18 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                         if (categories == null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<li>loading</li>");
#nullable restore
#line 21 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                             foreach (var item in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "li");
                __builder2.OpenElement(33, "a");
                __builder2.AddAttribute(34, "class", "dropdown-item");
                __builder2.AddAttribute(35, "href", "categories/" + (
#nullable restore
#line 26 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                                                                               item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, 
#nullable restore
#line 26 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                                                                                         item.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 27 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
                             
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "products");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Products");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "admin");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(48, "Admin Page");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n\r\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
       

  

    private Category[] categories;

    private async Task GetCategoriesAsync()
    {
        categories = await Http.GetFromJsonAsync<Category[]>("https://localhost:44398/api/Categories");

        StateHasChanged();

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\X\source\repos\dotnetwebshop\BlazorFrontend\Shared\NavBar.razor"
               

    }

   


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetCategoriesAsync();
    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
