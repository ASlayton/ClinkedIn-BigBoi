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
                new Services {Type = ServiceType.Haberdasher, Fees = FeeType.fourBottleCap},
                //new Services {Type = ServiceType.Protector, Fees = "100 bottlecaps"},
                //new Services {Type = ServiceType.Assassin, Fees = "100000 bottlecaps"},
                //new Services {Type = ServiceType.SnuggleBuddy, Fees = "100 bottlecaps"},
                // Services {Type = ServiceType.Smuggler, Fees = "100 bottlecaps"},
                // Services {Type = ServiceType.Priest, Fees = "10 bottlecaps"},
                //new Services {Type = ServiceType.Tattooist, Fees = "100 bottlecaps"},
                //new Services {Type = ServiceType.Hairdresser, Fees = "50 bottlecaps"},
                //new Services {Type = ServiceType.Trainer, Fees = "50 bottlecaps"},
                //new Services {Type = ServiceType.Snitch, Fees = "20 bottlecaps"},
                //new Services {Type = ServiceType.Mama, Fees = "50 bottlecaps"},
            };
        }

        // GET: api/Services- Returns all Existing Services
        [HttpGet]
        public ActionResult<IEnumerable<Services>> GetAll()
        {
            return Services;
        }


        //POST: api/Services
        [HttpPost]
        public IActionResult AddAService(Services services)
        {
            Services.Add(services);
            return Ok();
        }

        //Delete: api/Services
        [HttpDelete]
        public IActionResult DeleteAService(Services services)
        {
            Services.Remove(services);
            return Ok();
        }
 
    }
}
