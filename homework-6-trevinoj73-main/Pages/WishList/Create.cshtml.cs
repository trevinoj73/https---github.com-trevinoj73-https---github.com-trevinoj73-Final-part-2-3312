using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WishlistASP.Models;

namespace Final.Pages.WishList
{
    public class CreateModel : PageModel
    {
        private readonly WishlistASP.Models.WishlistContext _context;

        public CreateModel(WishlistASP.Models.WishlistContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Wish Wish { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wishes.Add(Wish);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
