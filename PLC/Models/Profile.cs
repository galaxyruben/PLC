using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLC.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "e-mail")]
        public string Email { get; set; }

        // Connecties
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }

    }
}