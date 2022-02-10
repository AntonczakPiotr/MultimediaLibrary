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
        [Required]
        public int LibraryCardID { get; set; }

        [Required]
        public int PersonID { get; set; }

        [Display(Name = "Data wydania")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data ważności")]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [Display(Name = "Stan")]
        public State State { get; set; }

        public Person Person { get; set; }

    }
}
