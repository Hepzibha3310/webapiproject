using charitableLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charitableLibrary.VolunteerData
{
    public class VolunteerDataAccess : IVolunteerDataAccess
    {
        private readonly GothamCareContext _context;
        public VolunteerDataAccess(GothamCareContext context)
        {
            _context = context;
        }
        public void AddVolunteerRecord(Volunteer volunteer)
        {
            _context.volunteers.Add(volunteer);
            _context.SaveChanges();

        }
        public void UpdateVolunteerRecord(Volunteer volunteer)
        {
            _context.volunteers.Update(volunteer);
            _context.SaveChanges();
        }


        public void DeleteVolunteerRecord(string VolunteerID)
        {
            var entity = _context.volunteers.FirstOrDefault(t => t.VolunteerID == VolunteerID);
            _context.volunteers.Remove(entity);
            _context.SaveChanges();

        }



        public Volunteer GetVolunteerSingleRecord(string VolunteerID)
        {
            return _context.volunteers.FirstOrDefault(t => t.VolunteerID == VolunteerID);
        }


        public List<Volunteer>  GetVolunteerRecord()
        {
            return _context.volunteers.ToList();
        }

    }
}
