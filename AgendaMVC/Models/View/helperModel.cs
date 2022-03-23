using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaMVC.Models.View
{
    public class helperModel
    {
        [Required]
        [StringLength (100, ErrorMessage = " el {0} tiene que tener minimo {1} caracter", MinimumLength = 1)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " el {0} tiene que tener minimo {1} caracter", MinimumLength = 1)]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }
    }
}