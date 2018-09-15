using System;
using System.Linq;
using ConsoleAppWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Product
        [HttpGet]
        public string GetClients()
        {
            var products = context.Clients.ToList();
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetClients")]
        public string GetClients(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string GetClients([FromForm] Client product)
        {
            context.Clients.Add(product);
            context.SaveChanges();

            return GetClients();
        }


        private string GetHtmlPage(string content)
        {
            string head = "<!DOCTYPE HTML PUBLIC \" -//IETF//DTD HTML 2.0//EN\">";
            return head + $"<html><head></head><body>{content}</body></html>";
        }
    }
}