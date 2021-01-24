using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices.ServiceOutlet
{
   public interface IOutletData
    {
     
        List<Outlet> GetOutlet();
        Outlet GetOutlet(int OutletID);
        Outlet AddOutlet(Outlet outlet);
        void DeleteOutlet(Outlet outlet);
    }
}

