using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using charitableLibrary.Models;

namespace charitableLibrary.Models
{
    public class DataAccess : IDataAcess
    {
        private readonly GothamCareContext  _context;
        public DataAccess(GothamCareContext context)
        {
            _context = context;
        }
        public void AddOutletRecord(Outlet outlet)
        {
            _context.outlets.Add(outlet);
            _context.SaveChanges();

        }
        public void UpdateOutletRecord(Outlet outlet)
        {
            _context.outlets.Update(outlet);
            _context.SaveChanges();
        }
        

        public void DeleteOutletRecord(string OutletID)
        {
            var entity = _context.outlets.FirstOrDefault (t => t.OutletID == OutletID);
            _context.outlets.Remove(entity);
            _context.SaveChanges();

        }

        

        public Outlet GetOutletSingleRecord(string OutletID)
        {
            return _context.outlets.FirstOrDefault(t => t.OutletID == OutletID);
        }


        public List<Outlet> GetOutletRecord()
        {
            return _context.outlets.ToList();
        }


    }
}
