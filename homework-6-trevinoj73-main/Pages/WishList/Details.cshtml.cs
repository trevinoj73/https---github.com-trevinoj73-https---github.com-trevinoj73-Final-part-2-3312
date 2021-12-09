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
    public class DetailsModel : PageModel
    {
        private readonly WishlistASP.Models.WishlistContext _context;

        public DetailsModel(WishlistASP.Models.WishlistContext context)
        {
            _context = context;
        }

        public Wish Wish { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wish = await _context.Wishes.Include(m =>m.Links).FirstOrDefaultAsync(m => m.WishID == id);

            if (Wish == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
