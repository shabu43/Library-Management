using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementProj.Models
{
    public class Payment
    {
        [Required]
        public int MemberId { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public string PaymentType { get; set; }


    }
}