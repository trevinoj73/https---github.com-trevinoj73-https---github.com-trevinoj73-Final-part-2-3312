using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WishlistASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using LinkASP.Models;


namespace Final.Pages.WishList
{
    public class AddLinkModel : PageModel
    {
        private readonly ILogger<AddLinkModel> _logger;
        private readonly WishlistContext _context;
        [BindProperty]
        public Link Link {get; set;}
        public SelectList WishDropDown {get; set;}
       

        public AddLinkModel(WishlistContext context, ILogger<AddLinkModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            WishDropDown = new SelectList(_context.Wishes.ToList(), "WishID", "Name");
        }
    

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Links.Add(Link);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}