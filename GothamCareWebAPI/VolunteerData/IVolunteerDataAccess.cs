using charitableLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace charitableLibrary.VolunteerData
{
    public interface IVolunteerDataAccess
    {
        void AddVolunteerRecord(Volunteer volunteer);
        void UpdateVolunteerRecord(Volunteer outlet);
        void DeleteVolunteerRecord(string VolunteerID);
        Volunteer GetVolunteerSingleRecord(string VolunteerID);
        List<Volunteer> GetVolunteerRecord();

    }
}
