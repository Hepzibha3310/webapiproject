using BusinessServices.ServiceVolunteer;
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
    public class VolunteerController : ControllerBase
    {
        private IVolunteerData _volunteerData;
        public VolunteerController(IVolunteerData volunteerData)
        {
            _volunteerData = volunteerData;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IActionResult GetVolunteer()
        {
            return Ok(_volunteerData.GetVolunteer());
        }
        [HttpGet]
        [Route("api/[Controller]/{id}")]
        public IActionResult GetVolunteer(int VolunteerID)
        {
            var volunteer = _volunteerData.GetVolunteer(VolunteerID);
            if (volunteer != null)
            {
                return Ok(volunteer);
            }
            return NotFound($"Outlet with id:{ VolunteerID } Was Not Found!");
        }
        [HttpPost]
        [Route("api/[Controller]")]
        public IActionResult AddVolunteer(Volunteer volunteer)
        {
            _volunteerData.AddVolunteer(volunteer);
            return Ok(volunteer);
        }
        [HttpDelete]
        [Route("api/[Controller]/{id}")]
        public IActionResult DeleteVolunteer(int VolunteerID)
        {
            var volunteer = _volunteerData.GetVolunteer(VolunteerID);
            if (volunteer != null)
            {
                _volunteerData.DeleteVolunteer(volunteer);
                return Ok();
            }
            return NotFound(" Was Not Found!");
        }
    }
}
