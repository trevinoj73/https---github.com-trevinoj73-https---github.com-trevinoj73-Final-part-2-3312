using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace  homework_6_trevinoj73.Models 
{
    public class Link
{
    public int ID {get;set;}

    [Required]
     [Url]
    public string URLLink {get;set;}
    
     [Display(Name = "Name")]
        [Required]
    public int WishId {get;set;}
    public Wish Wish {get;set;}
}
}

