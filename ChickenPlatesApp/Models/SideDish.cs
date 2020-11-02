﻿using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class SideDish
    {
        [Key]
        public long id { get; set; }
        [MaxLength(250)]
        public string DishName { get; set; }
    }
}
