using BusinessServices.ServiceAdmin;
using DataServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCaresCharitableSociety.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminData _adminData;
        public AdminController(IAdminData adminData)
        {
            _adminData = adminData;
        }

        [HttpGet("Login/{Email}/{Password}")]
        public IActionResult Login(string Email, string Password)
        {
            Admin admin = _adminData.login(Email, Password);
            if (admin == null)
            {
                return NotFound("wrong");
            }
            else if (!(admin.Password).Equals(Password))
            {
                return NotFound("wrong");
            }
            else
            {
                return Ok("login success");
            }
        }
    }
}
