using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    /// <summary>
    /// Płeć osoby
    /// </summary>
    public enum Gender
    {
        [Display(Name = "Mężczyzna")]
        Male = 1,
        [Display(Name = "Kobieta")]
        Female = 2,
    }
}
