using System;
using System.Collections.Generic;
using System.Text;

namespace charitableLibrary.Models
{
    public class Outlet
    {
        public string OutletID { get; set; }
        public string OutletName { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }
        public int NumberOfAvailableFoodPacks { get; set; }
        public int NumberOfVolunteersRequired { get; set; }
        public string TypeOfFood { get; set; }
        public DateTime Date { get; set; }

    }
}
