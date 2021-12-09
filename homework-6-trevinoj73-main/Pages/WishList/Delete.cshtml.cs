using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WishlistASP.Models;

namespace Final.Pages.WishList
{
    public class DeleteModel : PageModel
    {
        private readonly WishlistASP.Models.WishlistContext _context;

        public DeleteModel(WishlistASP.Models.WishlistContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Wish Wish { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wish = await _context.Wishes.FirstOrDefaultAsync(m => m.WishID == id);

            if (Wish == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wish = await _context.Wishes.FindAsync(id);

            if (Wish != null)
            {
                _context.Wishes.Remove(Wish);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
