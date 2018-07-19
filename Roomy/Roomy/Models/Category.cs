using Roomy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Areas.BackOffice.Models
{
    public class Category : BaseModel
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage ="Le champs {0} doit contenir entre {2} et {1} caractères")]
        [Display(Name = "Libellé")]
        public string Name { get; set; }

    }
}