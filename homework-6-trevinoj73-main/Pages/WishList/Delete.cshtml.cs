using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using homework_6_trevinoj73.Models;

namespace homework_6_trevinoj73.Pages.WishList
{
    public class DeleteModel : PageModel
    {
        private readonly homework_6_trevinoj73.Models.WishlistContext _context;

        public DeleteModel(homework_6_trevinoj73.Models.WishlistContext context)
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

            Wish = await _context.Wish.FirstOrDefaultAsync(m => m.WishID == id);

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

            Wish = await _context.Wish.FindAsync(id);

            if (Wish != null)
            {
                _context.Wish.Remove(Wish);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
