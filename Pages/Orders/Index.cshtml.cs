using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClothShop.Data;
using ClothShop.Models;

namespace ClothShop.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ClothShop.Data.ClothShopContext _context;

        public IndexModel(ClothShop.Data.ClothShopContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order
                .Include(o => o.Brand)
                .Include(o => o.Category).ToListAsync();
        }
    }
}
