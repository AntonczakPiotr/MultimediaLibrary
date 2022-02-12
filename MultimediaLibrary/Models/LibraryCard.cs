using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    public class LibraryCard
    {
        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        public int LibraryCardID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Range(10000000, 99999999, ErrorMessage = "Numer karty musi mieć 8 cyfr")]
        [Display(Name = "Numer karty")]
        public int LibraryCardNumber { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Display(Name = "Właściciel")]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [DataType(DataType.Date)]
        [Display(Name = "Data wydania")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data ważności")]
        public DateTime? ExpirationDate { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Stan")]
        public State State { get; set; }

        public Person Person { get; set; }

        //public LibraryCard()
        //{
        //    LibraryCardNumber = 99999999;
        //}
    }
}
