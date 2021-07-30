using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInfo.Models
{
    public class Students
    {
        public int id { get; set; }
        [DisplayName("Lastname")]
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        [DisplayName("Firstname")]
        [Required(ErrorMessage = "Lastname is required")]
        public string Firstname { get; set; }

    }
}