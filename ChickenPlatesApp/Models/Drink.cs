using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long id { get; set; }
        [MaxLength(250)]
        public string DrinkName { get; set; }

    }
}
