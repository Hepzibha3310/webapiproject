using BusinessServices.ServiceOutlet;
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
    public class OutletController : ControllerBase
    {
        private IOutletData _outletData;
        public OutletController(IOutletData outletData)
        {
            _outletData = outletData;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IActionResult GetOutlet()
        {
            return Ok(_outletData.GetOutlet());
        }
        [HttpGet]
        [Route("api/[Controller]/{id}")]
        public IActionResult GetOutlet(int OutletID)
        {
            var outlet = _outletData.GetOutlet(OutletID);
            if (outlet != null)
            {
                return Ok(outlet);
            }
            return NotFound($"Outlet with id:{ OutletID } Was Not Found!");
        }
        [HttpPost]
        [Route("api/[Controller]")]
        public IActionResult AddOutlet(Outlet outlet)
        {
            _outletData.AddOutlet(outlet);
            return Ok(outlet);
        }
        [HttpDelete]
        [Route("api/[Controller]/{id}")]
        public IActionResult DeleteOutlet(int OutletID)
        {
            var outlet = _outletData.GetOutlet(OutletID);
            if (outlet != null)
            {
                _outletData.DeleteOutlet(outlet);
                return Ok();
            }
            return NotFound(" Was Not Found!");
        }
    }
}
