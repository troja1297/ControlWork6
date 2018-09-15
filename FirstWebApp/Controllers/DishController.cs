using System.Linq;
using ConsoleAppWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DishController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Product
        [HttpGet]
        public string GetDishes()
        {
            var products = context.Dishes.ToList();
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetDishes")]
        public string GetDishes(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string GetDishes([FromForm] Dish product)
        {
            context.Dishes.Add(product);
            context.SaveChanges();

            return GetDishes();
        }

        

        private string GetHtmlPage(string content)
        {
            string head = "<!DOCTYPE HTML PUBLIC \" -//IETF//DTD HTML 2.0//EN\">";
            return head + $"<html><head></head><body>{content}</body></html>";
        }
    }
}