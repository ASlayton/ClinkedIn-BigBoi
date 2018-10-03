using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
                new Inmates { Id = 3, Name = "Jerry", IsMember = true, Interests = new Interests { Type = InterestType.EatingCheezItsByTheBox}, Services = new Services {Type = ServiceType.SnuggleBuddy }, Gender = Inmates.Sex.Male  },
                new Inmates { Id = 4, Name = "Penelope", IsMember = true, Interests = new Interests { Type = InterestType.HeavyBreathing}, Services = new Services {Type = ServiceType.Smuggler }, Gender = Inmates.Sex.Female  }
            };
        }
    }
}