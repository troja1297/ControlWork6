using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleAppWithDb.Models
{
    public class Institution : Entity
    {
        [FromForm (Name = "description")]
        public string Description { get; set; }
        [FromForm (Name = "name")]
        public string Name { get; set; }
    }  
    
    public class Dish : Entity
    {
        [FromForm (Name = "description")]
        public string Description { get; set; }
        [FromForm (Name = "name")]
        public string Name { get; set; }
        [FromForm (Name = "price")]
        public decimal Price { get; set; }
        
        [ForeignKey("Institution")]
        [FromForm (Name = "cafeId")]
        public int InstitutionId { get; set; }
    }  
    
    public class Client : Entity
    {
        [FromForm (Name = "contact")]
        public string Contact { get; set; }
        [FromForm (Name = "name")]
        public string Name { get; set; }
    }  
    
    public class Order : Entity
    {
        public DateTime Date { get; set; }
        
        [ForeignKey("Institution")]
        [FromForm (Name = "cafeId")]
        public int CafeId { get; set; }
        
        [ForeignKey("Dish")]
        [FromForm (Name = "dishId")]
        public int DishId { get; set; }
    }  
}

