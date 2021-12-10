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
    public class IndexModel : PageModel
    {
        private readonly homework_6_trevinoj73.Models.WishlistContext _context;

        public IndexModel(homework_6_trevinoj73.Models.WishlistContext context)
        {
            _context = context;
        }

        public IList<Wish> Wish { get;set; }

       [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
        
            var query = _context.Wish.Select(w => w);

            switch (CurrentSort)
            {
                case "Title_asc": 
                    query = query.OrderBy(w=> w.Title);
                    break;
               
                case "Title_desc":
                    query = query.OrderByDescending(w => w.Title);
                    break;
                     case "Version_asc":
                    query = query.OrderByDescending(w => w.Version);
                    break;
                     case "Version_desc":
                    query = query.OrderByDescending(w => w.Version);
                    break;
                    case "Price_asc":
                    query = query.OrderByDescending(w => w.Price);
                    break;
                    case "Price_desc":
                    query = query.OrderByDescending(w => w.Price);
                    break;
                    
               
            }

            
            Wish = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
}
}