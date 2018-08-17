using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLC.Models
{
    public class CarDetails
    {
        public int Id { get; set; }    
        [Display(Name = "Exterieurkleur")]
        public string Colour1 { get; set; }

        
        [Display(Name = "interieur kleur")]
        public string Colour2 { get; set; }

        
        [Display(Name = "Options")]
        public string Color { get; set; }

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
        public CarDetails()
        {
            this.CreatedAt = DateTime.Now;
        }
    }
}