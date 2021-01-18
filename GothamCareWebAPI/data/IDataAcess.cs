using System;
using System.Collections.Generic;
using System.Text;

namespace charitableLibrary.Models
{
    public interface IDataAcess
    {
        void AddOutletRecord(Outlet outlet);
        void UpdateOutletRecord(Outlet outlet);
        void DeleteOutletRecord(string OutletID);
        Outlet GetOutletSingleRecord(string OutletID);
        List<Outlet> GetOutletRecord();

       

    }
}

