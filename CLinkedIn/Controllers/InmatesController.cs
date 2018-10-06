using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CLinkedIn.Models;
using CLinkedIn.DataAccess;

namespace CLinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        //static List<Inmates> Inmate;

        //static InmatesController()
        //{
        //Inmate = new List<Inmates>
        //{
        //new Inmates { Id = 0, Name = "Jerry", IsMember = true, Interests = Interests.EatingCheezItsByTheBox, Services = new Services {Type = ServiceType.SnuggleBuddy }, Gender = Inmates.Sex.Male  },
        //new Inmates { Id = 4, Name = "Penelope", IsMember = true, Interests = Interests.HeavyBreathing, Services = new Services {Type = ServiceType.Smuggler }, Gender = Inmates.Sex.Female  }
        //};
        //}

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
 
        [HttpGet("Interests/{interests}")]
        public ActionResult<IEnumerable<Interests>> GetInmatesInterestedInCheezIts(Interests interests)
        {
            var storage = new InmateStorage();
            var interestInmate = storage.GetAllInmates().Where(inmate => inmate.Interests == interests);
            return Ok(interestInmate);
        }
    }
}