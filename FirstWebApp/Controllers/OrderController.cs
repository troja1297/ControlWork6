using System;
using System.Linq;
using ConsoleAppWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstWebApp.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Product
        [HttpGet]
        public string GetOrders()
        {
            var products = context.Orders.ToList();
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetOrders")]
        public string GetOrders(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string GetOrders([FromForm] Order product)
        {
            product.Date = DateTime.Now;
            context.Orders.Add(product);
            context.SaveChanges();

            return GetOrders();
        }


        private string GetHtmlPage(string content)
        {
            string head = "<!DOCTYPE HTML PUBLIC \" -//IETF//DTD HTML 2.0//EN\">";
            return head + $"<html><head></head><body>{content}</body></html>";
        }
    }
}