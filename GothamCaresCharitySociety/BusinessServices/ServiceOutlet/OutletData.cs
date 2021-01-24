using DataServices;
using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessServices.ServiceOutlet
{
    public class OutletData :IOutletData
    {
        private GothamCareContext _gothamCareContext;
        public OutletData(GothamCareContext gothamCareContext)
        {
            _gothamCareContext = gothamCareContext;
        }

        public Outlet AddOutlet(Outlet outlet)
        {
            _gothamCareContext.Outlet.Add(outlet);
            _gothamCareContext.SaveChanges();
            return outlet;
        }

        public void DeleteOutlet(Outlet outlet)
        {
            _gothamCareContext.Outlet.Remove(outlet);
            _gothamCareContext.SaveChanges();
        }

        public Outlet GetOutlet(int OutletID)
        {
            var outlet = _gothamCareContext.Outlet.Find(OutletID);
            return outlet;
        }

        public List<Outlet> GetOutlet()
        {
            return _gothamCareContext.Outlet.ToList();
        }
    }
}
