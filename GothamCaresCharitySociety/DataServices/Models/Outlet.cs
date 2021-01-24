using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServices.Models
{
    public class Outlet
    {
        [Key]
        public int OutletID { get; set; }
        [Required]
        public string OutletName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string Landmark { get; set; }
        [Required]
        public int NumberOfAvailableFoodPacks { get; set; }
        [Required]
        public int NumberOfVolunteersRequired { get; set; }
        [Required]
        public string TypeOfFood { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

    }
}
