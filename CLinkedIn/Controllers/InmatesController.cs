using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CLinkedIn.Models;

namespace CLinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        static List<Inmates> Inmate;

        static InmatesController()
        {
            Inmate = new List<Inmates>
            {
                new Inmates { Id = 3, Name = "Jerry", IsMember = true, Interests = new Interests { Type = InterestType.EatingCheezItsByTheBox}, PersonalServices = new Services("100 bottlecaps", ServiceType.SnuggleBuddy), Gender = Inmates.Sex.Male  },
                new Inmates { Id = 4, Name = "Penelope", IsMember = true, Interests = new Interests { Type = InterestType.HeavyBreathing}, PersonalServices = new Services("20 bottlecaps", ServiceType.Snitch), Gender = Inmates.Sex.Female  }
            };
        }


        [HttpGet("haberdasher")]
        public ActionResult<IEnumerable<Inmates>>GetHaberdashers()
        {
            var haberdashers = Inmate.Where(inmate => inmate.PersonalServices.Equals(ServiceType.Haberdasher));
            return Ok(haberdashers);
        }

        [HttpGet("Protectors")]
        public ActionResult<IEnumerable<Inmates>> GetProtector()
        {
            var protectors = Inmate.Where(inmate => inmate.PersonalServices.Equals(ServiceType.Protector));
            return Ok(protectors);
        }
    }
}