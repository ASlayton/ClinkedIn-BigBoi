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
 
        [HttpGet("{Interests}")]
        public ActionResult<IEnumerable<Interests>> GetInmatesInterestedInCheezIts()
        {
            var storage = new InmateStorage();
            var cheezItsInmate = storage.GetAllInmates().Where(inmate => inmate.Interests == Interests.EatingCheezItsByTheBox);
            return Ok(cheezItsInmate);
        }


        [HttpGet("service/haberdashers")]
        public ActionResult<IEnumerable<Inmates>>GetHaberdashers(string service)
        {
            var storage = new InmateStorage();
            var haberdashers = storage.GetAllInmates().Where(inmate => inmate.PersonalServices.Equals(ServiceType.Haberdasher));
            return Ok(haberdashers);
        }

        [HttpGet("service/protectors")]
        public ActionResult<IEnumerable<Inmates>> GetProtector()
        {
            var storage = new InmateStorage();
            var protectors = storage.GetAllInmates().Where(inmate => inmate.PersonalServices.Equals(ServiceType.Protector));
            return Ok(protectors);
        }

        [HttpGet("service/assassin")]
        public ActionResult<IEnumerable<Inmates>> GetAssassin()
        {
            var storage = new InmateStorage();
            var assassin = storage.GetAllInmates().Where(inmate => inmate.PersonalServices.Equals(ServiceType.Assassin));
            return Ok(assassin);
        }
    }
}