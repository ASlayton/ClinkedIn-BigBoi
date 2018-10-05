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
        static List<MyServices> Services;
        static ServicesController()
        {
            Services = new List<MyServices>
            {
                new MyServices {Type = ServiceType.Haberdasher, Fees = "10 bottlecaps"},
                new MyServices {Type = ServiceType.Protector, Fees = "100 bottlecaps"},
                new MyServices {Type = ServiceType.Assassin, Fees = "100000 bottlecaps"},
                new MyServices {Type = ServiceType.SnuggleBuddy, Fees = "100 bottlecaps"},
                new MyServices {Type = ServiceType.Smuggler, Fees = "100 bottlecaps"},
                new MyServices {Type = ServiceType.Priest, Fees = "10 bottlecaps"},
                new MyServices {Type = ServiceType.Tattooist, Fees = "100 bottlecaps"},
                new MyServices {Type = ServiceType.Hairdresser, Fees = "50 bottlecaps"},
                new MyServices {Type = ServiceType.Trainer, Fees = "50 bottlecaps"},
                new MyServices {Type = ServiceType.Snitch, Fees = "20 bottlecaps"},
                new MyServices {Type = ServiceType.Mama, Fees = "50 bottlecaps"},
            };
        }

        // GET: api/Services- Returns all Existing Services
        [HttpGet]
        public ActionResult<IEnumerable<MyServices>> GetAll()
        {
            return Services;
        }


        //POST: api/Services
        [HttpPost]
        public IActionResult AddAService(MyServices services)
        {
            Services.Add(services);
            return Ok();
        }

        //Delete: api/Services
        [HttpDelete]
        public IActionResult DeleteAService(MyServices services)
        {
            Services.Remove(services);
            return Ok();
        }
 
    }
}
