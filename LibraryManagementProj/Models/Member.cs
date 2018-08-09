using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementProj.Models
{
    public class Member
    {
        [Required]
        public int MemberId { get; set; }

        [Required]
        public String MemberName { get; set; }

        [Required]
        public String MemberType { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }

        [Required]
        public String PhoneNumber { get; set; }

        [Required]
        public String Address { get; set; }
    }
}