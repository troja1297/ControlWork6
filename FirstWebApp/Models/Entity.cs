using System.ComponentModel.DataAnnotations;

namespace ConsoleAppWithDb.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}