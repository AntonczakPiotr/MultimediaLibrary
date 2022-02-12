using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaLibrary.Enums
{
    /// <summary>
    /// Typy zasobów możliwych do przechowywania w bibliotece
    /// </summary>
    public enum MediaType
    {
        [Display(Name = "Książka")]
        Book = 1,

        [Display(Name = "Czasopismo")]
        Journal = 2,

        [Display(Name = "Płyta CD")]
        CompactDisc = 3,

        [Display(Name = "E-book")]
        Ebook = 4,

        [Display(Name = "Audio-book")]
        Audiobook = 5,

        [Display(Name = "Pendrive")]
        Pendrive = 6,
    }
}
