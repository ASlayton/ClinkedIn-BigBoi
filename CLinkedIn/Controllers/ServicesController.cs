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
    public class ServicesController : ControllerBase
    {
        static List<Services> Services;
        static ServicesController()
        {
            Services = new List<Services>
            {
                new Services {Type = ServiceType.Haberdasher, Fees = "10 bottlecaps"},
                new Services {Type = ServiceType.Protector, Fees = "100 bottlecaps"},
                new Services {Type = ServiceType.Assassin, Fees = "100000 bottlecaps"},
                new Services {Type = ServiceType.SnuggleBuddy, Fees = "100 bottlecaps"},
                new Services {Type = ServiceType.Smuggler, Fees = "100 bottlecaps"},
                new Services {Type = ServiceType.Priest, Fees = "10 bottlecaps"},
                new Services {Type = ServiceType.Tattooist, Fees = "100 bottlecaps"},
                new Services {Type = ServiceType.Hairdresser, Fees = "50 bottlecaps"},
                new Services {Type = ServiceType.Trainer, Fees = "50 bottlecaps"},
                new Services {Type = ServiceType.Snitch, Fees = "20 bottlecaps"},
                new Services {Type = ServiceType.Mama, Fees = "50 bottlecaps"},
            };
        }

        // GET: api/Services- Returns all Existing Services
        [HttpGet]
        public ActionResult<IEnumerable<Services>> GetAll()
        {
            return Services;
        }

        // GET: api/Services/5
        [HttpGet("{id}", Name = "AvailableService")]
        public string Get(int id)
        {
            var inmate = _s
            var Available = 
            return Available;
        }

        //POST: api/Services
        [HttpPost]
        public IActionResult AddAService(Services services)
        {
            Services.Add(services);
            return Ok();
        }

        // PUT: api/Services/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{}
    }
}
