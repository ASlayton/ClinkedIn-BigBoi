using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CLinkedIn.DataAccess;
using CLinkedIn.Models;

namespace CLinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        private readonly InmateStorage _inmates;

        public InmatesController()
        {
            _inmates = new InmateStorage();
        }
        // POST: api/Inmates
        [HttpPost]
        public void AddACriminal(Inmates inmates)
        {
            _inmates.CreateInmate(inmates);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Inmates>> GetAll()
        {
            var storage = new InmateStorage();
            var inmates = storage.GetAllInmates();
            return Ok(inmates);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleInmate(int id)
        {
            var storage = new InmateStorage();
            var singleInmate = storage.GetAllInmates().Where(inmate => inmate.Id == id);
            return Ok(singleInmate);
        }

        [HttpGet("{Interests}")]
        public ActionResult<IEnumerable<Interests>> GetInmatesInterestedInCheezIts()
        {
            var storage = new InmateStorage();
            var cheezItsInmate = storage.GetAllInmates().Where(inmate => inmate.Interests == Interests.EatingCheezItsByTheBox);
            return Ok(cheezItsInmate);
        }
        [HttpDelete("{id}")]
        public void Delete(int id, Inmates inmates)
        {
            _inmates.DeleteAConvict(id);
            //var storage = new InmateStorage();
            //storage.GetAllInmates().ToList().Remove(inmate => inmate.Id == id);
            // _inmates.GetAllInmates().ToList().Remove(inmates => inmates.Id == id);
        }
    }
}
