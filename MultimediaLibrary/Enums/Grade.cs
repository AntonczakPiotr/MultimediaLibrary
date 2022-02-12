using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    /// <summary>
    /// Ocena
    /// </summary>
    public enum Grade
    {
        [Display(Name = "Świetna(y)")]
        A = 1,
        [Display(Name = "Dobra(y)")]
        B = 2,
        [Display(Name = "Przeciętna(y)")]
        C = 3,
        [Display(Name = "Słaba(y)")]
        D = 4,
        [Display(Name = "Kontrowersyjna(y)")]
        F = 5
    }
}



