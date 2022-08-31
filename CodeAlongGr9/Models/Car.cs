using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAlongGr9.Models
{
    public class Car
    {
        [Key]
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public string CarModel { get; set; }
       
        public List<Person> People { get; set; } = new List<Person>();

        //public Car()
        //{
        //    People = new List<Person>(); 
        //}
    }
}
