using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class Person
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age {  get; set; }
    }
}
