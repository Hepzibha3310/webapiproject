using charitableLibrary.Models;
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
    public class OutletsController : ControllerBase
    {
        private readonly IDataAcess _dataAcess;

        public OutletsController(IDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }

        [HttpGet]
        public IEnumerable<Outlet> Get()
        {
            return _dataAcess.GetOutletRecord();
        }

        [HttpPost]
        public IActionResult Create ([FromBody]Outlet outlet)
        {
          if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                outlet.OutletID = obj.ToString();
                _dataAcess.AddOutletRecord(outlet);
                return Ok();

            }
            return BadRequest();
        }
        
        [HttpGet ("{ID}")]
        public Outlet Details(string OutletID)
        {
            return _dataAcess.GetOutletSingleRecord(OutletID);
        }
        
        [HttpPut]
        public IActionResult Edit([FromBody] Outlet outlet)
        {
            if (ModelState.IsValid)
            {
                _dataAcess.UpdateOutletRecord(outlet);
                return Ok();

            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteConfirmed(string OutletID)
        {
            var data = _dataAcess.GetOutletSingleRecord(OutletID);
            if (data == null)
            {
                return NotFound();
            }
            _dataAcess.DeleteOutletRecord(OutletID);
            return Ok();

        }




    }
    

             
    



}
    

