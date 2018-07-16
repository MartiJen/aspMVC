using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class User
    {
        [Required(ErrorMessage = "Le champ nom est obligatoire")]
        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le champ nom est obligatoire")]
        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Le champ nom est obligatoire")]
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Le champ nom est obligatoire")]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmation du mot de passe")]
        [DataType(DataType.Password)]
        public string ConfirmePassword { get; set; }
    }
}