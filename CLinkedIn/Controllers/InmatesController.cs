using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn_BigBoi.DataAccess;
using ClinkedIn_BigBoi.Models;


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

    }
}
