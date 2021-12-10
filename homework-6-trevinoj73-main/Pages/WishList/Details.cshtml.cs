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
    public class DetailsModel : PageModel
    {
        private readonly homework_6_trevinoj73.Models.WishlistContext _context;

        public DetailsModel(homework_6_trevinoj73.Models.WishlistContext context)
        {
            _context = context;
        }

        public Wish Wish { get; set; }
        [BindProperty]
        public int LinkIdToDeleat {get;set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wish = await _context.Wish.Include(m =>m.Links).FirstOrDefaultAsync(m => m.WishID == id);

            if (Wish == null)
            {
                return NotFound();
            }
            return Page();
    
        }
        public IActionResult OnPostDeleteReview(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

          
            Link Link = _context.Link.FirstOrDefault(L => L.ID == LinkIdToDeleat);
            
            if (Link != null)
            {
                _context.Remove(Link);
                _context.SaveChanges();
            }

            Wish = _context.Wish.Include(W => W.Links).FirstOrDefault(W => W.WishID == id);

            return Page();
        }        
    }
}
