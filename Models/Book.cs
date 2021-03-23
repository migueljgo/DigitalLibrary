using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DigitalLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required(ErrorMessage ="Required.")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage ="Required.")]
        public string BookAuthor { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string BookGenre { get; set; }
        [Display(Name ="Date Borrowed")]
        public DateTime DateBorrowed { get; set; }
        [Display(Name = "Date Returned")]
        public DateTime? DateReturned { get; set; }
    }

}
