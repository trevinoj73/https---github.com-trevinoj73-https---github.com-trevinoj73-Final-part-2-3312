using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using homework_6_trevinoj73.Models;

namespace homework_6_trevinoj73.Pages.WishList
{
    public class EditModel : PageModel
    {
        private readonly homework_6_trevinoj73.Models.WishlistContext _context;

        public EditModel(homework_6_trevinoj73.Models.WishlistContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Wish).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WishExists(Wish.WishID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WishExists(int id)
        {
            return _context.Wish.Any(e => e.WishID == id);
        }
    }
}
