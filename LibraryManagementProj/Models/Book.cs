using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementProj.Models
{
    public class Book
    {
        [Required]
        public int BookId { get; set; }

        [Required]
        public String BookName { get; set; }

        [Required]
        public String AuthorName { get; set; }

        [Required]
        public String Category { get; set; }

        [Required]
        public int Edition { get; set; }

        [Required]
        public float Price { get; set; }
    }
}