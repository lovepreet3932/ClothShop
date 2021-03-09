using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClothShop.Data;
using ClothShop.Models;

namespace ClothShop.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ClothShop.Data.ClothShopContext _context;

        public IndexModel(ClothShop.Data.ClothShopContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
