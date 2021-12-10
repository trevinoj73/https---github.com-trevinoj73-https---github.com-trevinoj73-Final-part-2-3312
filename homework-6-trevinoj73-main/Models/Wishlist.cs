using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace  homework_6_trevinoj73.Models
{
   public class Wish
{
    public int WishID { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Title { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(30)]
    public string Version { get; set; }

    public List<Link> Links {get;set;}

    
}
    }