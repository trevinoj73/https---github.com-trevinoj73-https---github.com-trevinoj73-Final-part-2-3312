using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using WishlistASP.Models;


namespace LinkASP.Models
{
    public class Link
{
    public int ID {get;set;}

    [Required]
     [Url]
    public string URLLink {get;set;}

    public int WishId {get;set;}
    public Wish Wish {get;set;}
}
}

