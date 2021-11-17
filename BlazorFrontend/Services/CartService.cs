//Senare - impmenentera uppdaterande cart



/*using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BlazorFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontend.Services
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage,
            IToastService toastService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
        }

        public async Task AddToCart(Product product)
        {
            var cart = await _localStorage.GetItemAsync<List<Product>>("cart");
            if (cart == null)
            {
                cart = new List<Product>();
            }
            cart.Add(Product);
            await _localStorage.SetItemAsync("cart", cart);
        }
    }
}
*/