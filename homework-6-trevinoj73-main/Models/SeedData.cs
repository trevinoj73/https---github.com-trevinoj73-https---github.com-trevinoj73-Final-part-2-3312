using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;
using LinkASP.Models;

namespace WishlistASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WishlistContext(
                serviceProvider.GetRequiredService<DbContextOptions<WishlistContext>>()))
            {
               
                if (context.Wishes.Any())
                {
                    return;   
                }

                context.Wishes.AddRange(
                    new Wish
                    {
                        Title = "Grift",
                        Version = "Modern Herizons 2",
                        Price = 13.03M,
                        Links = new List<Link> {
                          new Link {URLLink = "https://www.w3schools.com/bootstrap4/bootstrap_jumbotron.asp" }
                        }
                    },

                    new Wish
                    {
                      Title = "Disorder in the Court",
                        Version = "Innistrad: Crimson Vow",
                        Price = 1.31M,
                    },

                    new Wish
                    {
                        Title = "Haunted Library",
                        Version = "Innistrad: Crimson Vow",
                        Price = 1.30M,
                    },

                    new Wish
                    {
                        Title = "Innistrad: Crimson Vow",
                        Version = "Innistrad: Crimson Vow",
                        Price = 366.1M,
                       
                    },
                      new Wish
                    {
                        Title = "Sudden Salvation",
                        Version = "Innistrad: Crimson Vow",
                        Price = 0.88M,
                       
                    },
                      new Wish
                    {
                        Title = "Storm of Souls",
                        Version = "Innistrad: Crimson Vow",
                        Price = 0.82M,
                       
                    },
                      new Wish
                    {
                        Title = "Ethereal Investigator",
                        Version = "Innistrad: Crimson Vow",
                        Price = 0.76M,
                       
                    },
                      new Wish
                    {
                        Title = "Priest of the Blessed Graf",
                        Version = "Innistrad: Crimson Vow",
                        Price = 0.92M,
                       
                    },
                      new Wish
                    {
                        Title = "Abzan Falconer",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.10M,
                       
                    },
                      new Wish
                    {
                        Title = "Champion of Lambholt",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.29M,
                       
                    },
                      new Wish
                    {
                        Title = "Bastion Protector",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.10M,
                       
                    },
                      new Wish
                    {
                        Title = "Return to Dust",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.29M,
                       
                    },
                      new Wish
                    {
                        Title = "Swords to Plowshares",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 1.67M,
                       
                    },
                      new Wish
                    {
                        Title = "Celestial Judgment",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.21M,
                       
                    },
                      new Wish
                    {
                        Title = "Odric, Master Tactician",
                        Version = "Innistrad: Midnight Hunt",
                        Price = 0.22M,
                       
                    },
                      new Wish
                    {
                        Title = "Prosper, Tome-Bound",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 2.48M,
                       
                    },
                      new Wish
                    {
                        Title = "Grim Hireling",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 10.73M,
                       
                    },
                      new Wish
                    {
                        Title = "Druid of Purification",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 6.12M,
                       
                    },
                      new Wish
                    {
                        Title = "Holy Avenger",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 0.34M,
                       
                    },
                      new Wish
                    {
                        Title = "Holy Avenger",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 1.47M,
                       
                    },
                      new Wish
                    {
                        Title = "Robe of Stars",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 3.97M,
                       
                    },
                      new Wish
                    {
                        Title = "Neverwinter Hydra",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 0.39M,
                       
                    },
                      new Wish
                    {
                        Title = "Wand of Orcus",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 13.82M,
                       
                    },
                      new Wish
                    {
                        Title = "Hurl Through Hell",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 0.80M,
                       
                    },
                      new Wish
                    {
                        Title = "Fevered Suspicion",
                        Version = "Adventures In The Forgotten Realms",
                        Price = 0.42M,
                       
                    }

                );
                context.SaveChanges();
            }
        }
    }
}