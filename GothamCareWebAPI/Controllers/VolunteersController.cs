using charitableLibrary.Models;
using charitableLibrary.VolunteerData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCharityWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        private readonly IVolunteerDataAccess _volunteerdataAccess;

        public VolunteersController(IVolunteerDataAccess volunteerdataAcess)
        {
            _volunteerdataAccess = volunteerdataAcess;
        }

        [HttpGet]
        public IEnumerable<Volunteer> Get()
        {
            return _volunteerdataAccess.GetVolunteerRecord();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                volunteer.VolunteerID = obj.ToString();
                _volunteerdataAccess.AddVolunteerRecord(volunteer);
                return Ok();

            }
            return BadRequest();
        }

        [HttpGet("{ID}")]
        public Volunteer Details(string volunteerID)
        {
            return _volunteerdataAccess.GetVolunteerSingleRecord(volunteerID);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _volunteerdataAccess.UpdateVolunteerRecord(volunteer);
                return Ok();

            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteConfirmed(string VolunteerID)
        {
            var data = _volunteerdataAccess.GetVolunteerSingleRecord(VolunteerID);
            if (data == null)
            {
                return NotFound();
            }
            _volunteerdataAccess.DeleteVolunteerRecord(VolunteerID);
            return Ok();

        }

    }
}
