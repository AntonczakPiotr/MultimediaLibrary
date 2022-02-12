using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    /// <summary>
    /// Możliwe typy aktywności
    /// </summary>
    public enum ActivityType
    {
        [Display(Name = "Wypożyczenie")]
        Borrowing = 1,

        [Display(Name = "Zwrot")]
        Returning = 2,

        [Display(Name = "Zagubienie")]
        Lost = 3,
    }
}
