using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    /// <summary>
    /// Klase reprezentująca element zbioru biblioteki
    /// </summary>
    public class Supply
    {
        [Required]
        public int SupplyID { get; set; }

        [Required]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Autor")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Rodzaj")]
        public MediaType MediaType { get; set; }

        [Display(Name = "Opis")]
        public string Comment { get; set; }

        [Display(Name = "Ocena")]
        [DisplayFormat(NullDisplayText = "Brak oceny")]
        public Grade? Grade { get; set; }
    }
}
