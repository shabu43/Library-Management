using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementProj.Models
{
    public class BookIssue
    {
        [Required]
        public int MemberId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public DateTime DateIssue { get; set; }

        [Required]
        public DateTime DateReturn { get; set; }

    }
}