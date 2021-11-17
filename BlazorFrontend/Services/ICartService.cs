using BlazorFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontend.Services
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Product product);
    }
}
