using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppWithDb.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FirstWebApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Institution>()
                .HasData(JsonConvert.DeserializeObject<Institution[]>(File.ReadAllText("Seed/institutions.json")));

            modelBuilder.Entity<Order>()
                .HasData(JsonConvert.DeserializeObject<Order[]>(File.ReadAllText("Seed/orders.json")));

            modelBuilder.Entity<Client>()
                .HasData(JsonConvert.DeserializeObject<Client[]>(File.ReadAllText("Seed/clients.json")));

            modelBuilder.Entity<Dish>()
                .HasData(JsonConvert.DeserializeObject<Dish[]>(File.ReadAllText("Seed/dishs.json")));
        }
    }
}
