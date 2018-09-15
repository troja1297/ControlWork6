using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppWithDb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace FirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Product
        [HttpGet]
        public string GetProducts()
        {
            var products = context.Dishes.ToList();
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetProducts")]
        public string GetProducts(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string PostProducts([FromForm] Dish product)
        {
            context.Dishes.Add(product);
            context.SaveChanges();

            return GetProducts();
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void PutProduct(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
        }

        private string GetHtmlPage(string content)
        {
            string head = "<!DOCTYPE HTML PUBLIC \" -//IETF//DTD HTML 2.0//EN\">";
            return head + $"<html><head></head><body>{content}</body></html>";
        }
    }
}
