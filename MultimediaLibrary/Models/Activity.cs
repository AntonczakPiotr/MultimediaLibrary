using MultimediaLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Models
{
    public class Activity
    {
        [Required]
        public int ActivityID { get; set; }

        [Required]
        public int SupplyID { get; set; }

        [Required]
        public int PersonID { get; set; }

        [Required]
        [Display(Name = "Stan")]
        public ActivityType ActivityType { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime ActivityDate { get; set; }

        public Supply Supply { get; set; }

        public Person Person { get; set; }
    }
}
