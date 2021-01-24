using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.ServiceAdmin
{
    public interface IAdminData
    {
        
        Admin login(string Email, string Password);
    }

}

