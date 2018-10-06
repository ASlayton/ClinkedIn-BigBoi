using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CLinkedIn.DataAccess;
using CLinkedIn.Models;

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

        [HttpGet]
        public ActionResult<IEnumerable<Inmates>> GetAll()
        {
            var storage = new InmateStorage();
            var inmates = storage.GetAllInmates();
            return Ok(inmates);
        }
        [HttpGet("{id}")]
        public IActionResult GetSingleInmate(int id)
        {
            var storage = new InmateStorage();
            var singleInmate = storage.GetAllInmates().Where(inmate => inmate.Id == id);
            return Ok(singleInmate);
        }


        [HttpGet("Services/{services}")]
        public ActionResult<IEnumerable<Services>> GetInmatesWithAService(ServiceType services)
        {
            var storage = new InmateStorage();
            var inmateService = storage.GetAllInmates().Where(inmate => inmate.PersonalServices.Type == services);
            return Ok(inmateService);
        }
 
        [HttpGet("Interests/{interest}")]
        public ActionResult<IEnumerable<Interests>> GetInmatesInterestedInCheezIts(Interests interest)
        {
            var storage = new InmateStorage();
            var interestInmate = storage.GetAllInmates().Where(inmate => inmate.Interests == interest);
            return Ok(interestInmate);
        }

        [HttpGet("Friends/{id}")]
        public IActionResult GetSpecificInmatesFriends(int id)
        {
            var storage = new InmateStorage();
            var popularInmate = storage.GetInmateById(id);
            return Ok(popularInmate.Friends);
        }

        [HttpGet("Enemies/{id}")]
        public IActionResult GetSpecificInmatesEnemies(int id)
        {
            var storage = new InmateStorage();
            var popularInmateEnemies = storage.GetInmateById(id);
            return Ok(popularInmateEnemies.Enemies);
        }

        [HttpPut("AddFriend/{id}/{friendId}")]
        public ActionResult AddFriend(int id, int friendId)
        {
            var inmates = _inmates.GetAllInmates();
            var lonelyInmate = inmates.First(inmate => inmate.Id == id);
            var newFriend = inmates.FirstOrDefault(inmate => inmate.Id == friendId);
            if (lonelyInmate == null)
            {
                return BadRequest();
            }
            else if (!lonelyInmate.Friends.Contains(newFriend))
            {
                lonelyInmate.Friends.Add(newFriend);
                return Ok();
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut("AddEnemy/{id}/{enemyId}")]
        public ActionResult AddEnemy(int id, int enemyId)
        {
            var inmates = _inmates.GetAllInmates();
            var lonelyInmate = inmates.First(inmate => inmate.Id == id);
            var newEnemy = inmates.FirstOrDefault(inmate => inmate.Id == enemyId);
            if (lonelyInmate == null)
            {
                return BadRequest();
            }
            else if (!lonelyInmate.Enemies.Contains(newEnemy))
            {
                lonelyInmate.Enemies.Add(newEnemy);
                return Ok();
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _inmates.DeleteAConvict(id);
        }
    }
}
