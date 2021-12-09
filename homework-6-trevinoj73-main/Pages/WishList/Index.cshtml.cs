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
    public class IndexModel : PageModel
    {
        private readonly WishlistASP.Models.WishlistContext _context;

        public IndexModel(WishlistASP.Models.WishlistContext context)
        {
            _context = context;
        }

        public IList<Wish> Wish { get;set; }

        public async Task OnGetAsync()
        {
            Wish = await _context.Wishes.ToListAsync();
        }
    }
}
