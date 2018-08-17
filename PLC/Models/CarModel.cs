using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLC.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Auto Model")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Prijs")]
        public int Price { get; set; }

        [Display(Name = "Actief")]
        public bool Active { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Geplaatst op")]
        public DateTime CreatedAt { get; set; }

        // Connecties
        public List<Car> Car { get; set; }

        // Contructor
        public CarModel()
        {
            this.CreatedAt = DateTime.Now;
        }
    }
}