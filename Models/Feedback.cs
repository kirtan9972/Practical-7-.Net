using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public class Feedback
    {
        [Required]
        public string EnrollmentNumber { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}