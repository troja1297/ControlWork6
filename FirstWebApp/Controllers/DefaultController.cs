using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"sqr of {id} is {Math.Pow(id, 2)}";
        }

        // POST: api/Default/Privet
        [HttpPost("Privet")]
        public string Privet([FromForm] string value)
        {

            System.IO.File.AppendAllText("text.txt", "Привет " + value + "\n");

            return $"{value} message received";
        }

        // POST: api/Default/Poka
        [HttpPost("Poka")]
        public string Poka([FromForm] string value)
        {
            System.IO.File.AppendAllText("text.txt", "Пока " + value + "\n");

            return $"{value} message received";
        }
        
    }
}
