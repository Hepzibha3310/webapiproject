using DataServices;
using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.ServiceAdmin
{
    public class AdminData :IAdminData
    {
        private GothamCareContext _gothamCareContext;
        public AdminData(GothamCareContext gothamCareContext)
        {
            _gothamCareContext = gothamCareContext;
        }

        public Admin login(string Email, string Password)
        {
            return _gothamCareContext.Admin.Find(Email); ;
        }
    }
}
