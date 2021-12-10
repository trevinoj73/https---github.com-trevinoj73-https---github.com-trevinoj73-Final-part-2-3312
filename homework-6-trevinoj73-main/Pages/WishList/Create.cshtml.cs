using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using homework_6_trevinoj73.Models;

namespace homework_6_trevinoj73.Pages.WishList
{
    public class CreateModel : PageModel
    {
        private readonly homework_6_trevinoj73.Models.WishlistContext _context;

        public CreateModel(homework_6_trevinoj73.Models.WishlistContext context)
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

            _context.Wish.Add(Wish);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
