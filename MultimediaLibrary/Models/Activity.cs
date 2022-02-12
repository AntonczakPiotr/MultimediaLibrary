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
        [Display(Name = "Zasób")]
        public int SupplyID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Czytelnik")]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="Pole {0} jest wymagane")]
        [Display(Name = "Rodzaj aktywności")]
        public ActivityType ActivityType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [Display(Name = "Data")]
        public DateTime? ActivityDate { get; set; }

        public Supply Supply { get; set; }

        public Person Person { get; set; }
    }
}
