using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices.ServiceVolunteer
{
    public interface IVolunteerData
    {
        List<Volunteer> GetVolunteer();
        Volunteer GetVolunteer(int VolunteerID);
        Volunteer AddVolunteer(Volunteer volunteer);
        void DeleteVolunteer(Volunteer volunteer);
    }
}
