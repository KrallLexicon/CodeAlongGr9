using System.ComponentModel.DataAnnotations;

namespace CodeAlongGr9.Models
{
    public class Person
    {
        [Key]
        public string SSN { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>(); 
    }
}
