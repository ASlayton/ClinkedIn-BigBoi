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
    public class InterestsController : ControllerBase
    {
        static List<Interests> Interest;

        static InterestsController()
        {
            Interest = new List<Interests>
            {
                new Interests { Type = InterestType.EatingCheezItsByTheBox },
                new Interests { Type = InterestType.HeavyBreathing },
                new Interests { Type = InterestType.InterpretiveDance },
                new Interests { Type = InterestType.LongWalksOnTheBeachInMoonlight },
                new Interests { Type = InterestType.PaintingTurtleShells },
                new Interests { Type = InterestType.SittingInSilence },
                new Interests { Type = InterestType.TandemBiking },
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Interests>> GetAll()
        {
            return Interest;
        }
    }
}