using Microsoft.EntityFrameworkCore;
using LinkASP.Models;

namespace WishlistASP.Models
{
    public class WishlistContext : DbContext
    {
        public WishlistContext (DbContextOptions<WishlistContext> options)
            : base(options)
        {
        }

        public DbSet<Wish> Wishes { get; set; }

        public DbSet<Link> Links {get;set;}
        
    }
}