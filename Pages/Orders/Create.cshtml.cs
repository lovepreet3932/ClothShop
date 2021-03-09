using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClothShop.Data;
using ClothShop.Models;

namespace ClothShop.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly ClothShop.Data.ClothShopContext _context;

        public CreateModel(ClothShop.Data.ClothShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandID"] = new SelectList(_context.Set<Brand>(), "BrandID", "BrandID");
        ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "CategoryID", "CategoryID");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
