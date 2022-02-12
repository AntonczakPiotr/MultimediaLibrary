using MultimediaLibrary.Enums;
using MultimediaLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    /// <summary>
    /// Klasa reprezentująca element zbioru biblioteki
    /// </summary>
    public class Supply
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        public int SupplyID { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Display(Name = "Autor")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Display(Name = "Rodzaj")]
        public MediaType MediaType { get; set; }

        [DataType(DataType.MultilineText)]
        //[DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Opis")]
        public string Comment { get; set; }

        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Ocena")]
        public Grade? Grade { get; set; }

        public string Summary { get => $"{Title} - {Author} ({MediaType.GetDisplayName()})"; }

    }
}
