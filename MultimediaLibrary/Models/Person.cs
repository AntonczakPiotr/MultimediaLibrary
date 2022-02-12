using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    /// <summary>
    /// Klasa reprezentująca dane czytelników
    /// </summary>
    public class Person
    {
        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [EmailAddress]
        [DisplayFormat(NullDisplayText = "-")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Płeć")]
        public Gender? Gender { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime? DateOfBirth { get; set; }

        public ICollection<LibraryCard> LibraryCards { get; set; }
    
        public ICollection<Activity> Activities { get; set; }

        public string FullName { get => $"{LastName} {FirstName}"; }

    }
}
