using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using homework_6_trevinoj73.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace homework_6_trevinoj73.Pages
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
            
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            WishDropDown = new SelectList(_context.Wish.ToList(), "WishID", "Title");
        }
    

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Link.Add(Link);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}