using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    public class Person
    {
        [Required]
        public int PersonID { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Płeć")]
        public Gender Gender { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime? DateOfBirth { get; set; }

        public ICollection<LibraryCard> LibraryCards { get; set; }
    }
}
