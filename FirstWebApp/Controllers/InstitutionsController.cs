using System;
using System.Linq;
using ConsoleAppWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        
        public InstitutionController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Product
        [HttpGet]
        public string GetInstitutions()
        {
            var products = context.Institutions.ToList();
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetInstitution")]
        public string GetInstitutions(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string GetInstitutions([FromForm] Institution product)
        {
            context.Institutions.Add(product);
            context.SaveChanges();

            return GetInstitutions();
        }


        private string GetHtmlPage(string content)
        {
            string head = "<!DOCTYPE HTML PUBLIC \" -//IETF//DTD HTML 2.0//EN\">";
            return head + $"<html><head></head><body>{content}</body></html>";
        }
    }
}