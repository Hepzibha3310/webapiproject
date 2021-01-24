using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServices.Models
{
    public class Volunteer
    {
        [Key]
        public int VolunteerID { get; set; }
        [Required]
        public int OutletID { get; set; }
        [Required]
        public string VolunteerName { get; set; }
        [Required]
        public string VolunteerAddress { get; set; }
        [Required]
        public int VolunteerPhonenumber { get; set; }
        [Required]
        public string VolunteerEmail { get; set; }

    }
}
