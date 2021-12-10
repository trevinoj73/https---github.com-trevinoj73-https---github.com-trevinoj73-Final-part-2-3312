using Microsoft.EntityFrameworkCore;


namespace  homework_6_trevinoj73.Models 
{
    public class WishlistContext : DbContext
    {
        public WishlistContext (DbContextOptions<WishlistContext> options)
            : base(options)
        {
        }

        public DbSet<Wish> Wish { get; set; }

        public DbSet<Link> Link {get;set;}
        
    }
}