using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    /// <summary>
    /// Klasa obiektów aktywności
    /// Służy do rejestrowania kto, kiedy, co wypożyczył, zwrócił, lub zagubił zasób biblioteki
    /// </summary>
    public class Activity
    {
        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        public int ActivityID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        public int SupplyID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Rodzaj aktywności")]
        public ActivityType ActivityType { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm}")]
        [Display(Name = "Data")]
        public DateTime ActivityDate { get; set; }

        [Display(Name = "Zasób")]
        public Supply Supply { get; set; }

        [Display(Name = "Czytelnik")]
        public Person Person { get; set; }
    }
}
