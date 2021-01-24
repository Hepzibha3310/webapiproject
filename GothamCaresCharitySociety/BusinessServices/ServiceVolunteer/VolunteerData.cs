using DataServices;
using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessServices.ServiceVolunteer
{
    public class VolunteerData :IVolunteerData
    {
        private GothamCareContext _gothamCareContext;
        public VolunteerData(GothamCareContext gothamCareContext)
        {
            _gothamCareContext = gothamCareContext;
        }
        public Volunteer AddVolunteer(Volunteer volunteer)
        {
            _gothamCareContext.Volunteer.Add(volunteer);
            _gothamCareContext.SaveChanges();
            return volunteer;
        }

        public void DeleteVolunteer(Volunteer volunteer)
        {
            _gothamCareContext.Volunteer.Remove(volunteer);
            _gothamCareContext.SaveChanges();
        }



        public Volunteer GetVolunteer(int VolunteerID)
        {
            var volunteer = _gothamCareContext.Volunteer.Find(VolunteerID);
            return volunteer;
        }
        public List<Volunteer> GetVolunteer()
        {
            return _gothamCareContext.Volunteer.ToList();
        }
    }
}
