using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CLinkedIn.Models;
using CLinkedIn.DataAccess;

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

        [HttpGet]
        public ActionResult<IEnumerable<Inmates>> GetAll()
        {
            var storage = new InmateStorage();
            var inmates = storage.GetAllInmates();
            return Ok(inmates);
        }

        [HttpGet("Services/{services}")]
        public ActionResult<IEnumerable<Services>> GetInmatesWithAService(Services services)
        {
            var storage = new InmateStorage();
            var inmateService = storage.GetAllInmates().Where(inmate => inmate.PersonalServices.Type == services.Type);
            return Ok(inmateService);
        }
 
        [HttpGet("Interests/{interests}")]
        public ActionResult<IEnumerable<Interests>> GetInmatesInterestedInCheezIts(Interests interests)
        {
            var storage = new InmateStorage();
            var interestInmate = storage.GetAllInmates().Where(inmate => inmate.Interests == interests);
            return Ok(interestInmate);
        }
    }
}
