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
    public class DetailsModel : PageModel
    {
        private readonly ClothShop.Data.ClothShopContext _context;

        public DetailsModel(ClothShop.Data.ClothShopContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Brand)
                .Include(o => o.Category).FirstOrDefaultAsync(m => m.OrderID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
