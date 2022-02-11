using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    public enum State
    {
        [Display(Name = "Aktywna")]
        Active = 1,

        [Display(Name = "Nie aktywna")]
        InActive = 2,
    }
}
