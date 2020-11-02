using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long id { get; set; }

        [Required]
        [MaxLength(250)]
        public string DrinkName { get; set; }

        public ChickenPlate ChickenPlate { get; set; }
        public long ChikenPlateId { get; set; }

    }
}
