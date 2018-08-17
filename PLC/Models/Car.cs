using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PLC.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Geplaatst op")]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Gewijzigd op")]
        public DateTime UpdatedAt { get; set; }

        //conecties
        public CarModel CarModel { get; set; }
        [Display(Name = "Auto Model")]
        [ForeignKey("CarModel")]
        public int CarmodelId { get; set; }

        public CarType CarType { get; set; }
        [Display(Name = "Uitvoering")]
        [ForeignKey("CarType")]
        public int CarTypeId { get; set; }

        public CarDetails CarDetails { get; set; }
        [Display(Name = "Auto Details")]
        [ForeignKey("CarDetails")]
        public int CarDetailsId { get; set; }

        public ApplicationUser User { get; set; }
        [Display(Name = "Gebruiker")]
        public string UserId { get; set; }


        // Contructor
        public Car()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}