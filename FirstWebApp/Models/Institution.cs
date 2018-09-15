using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleAppWithDb.Models
{
    public class Institution : Entity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }  
    
    public class Dish : Entity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        [ForeignKey("Institution")]
        public int InstitutionId { get; set; }
    }  
    
    public class Client : Entity
    {
        public int Id { get; set; }
        public string Contact { get; set; }
        public string Name { get; set; }
    }  
    
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        
        [ForeignKey("Client")]
        [FromForm (Name = "cafeId")]
        public int ClientId { get; set; }
        [ForeignKey("Dish")]
        [FromForm (Name = "dishId")]
        public int DishId { get; set; }
    }  
}

