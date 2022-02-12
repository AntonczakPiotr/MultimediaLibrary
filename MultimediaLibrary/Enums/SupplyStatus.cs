using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    public enum SupplyStatus
    {
        [Display(Name = "Wypożyczono")]
        Borrowed = 1,

        [Display(Name = "Zwrócono")]
        Returned = 2,

        [Display(Name = "Zagubiono")]
        Losted = 3,
    }
}
