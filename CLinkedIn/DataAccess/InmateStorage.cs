using System;
using System.Collections.Generic;
using System.Text;
using CLinkedIn.Models;

namespace CLinkedIn.DataAccess
{
    public class InmateStorage
    {
        static List<Inmates> _inmates = new List<Inmates>();

        static InmateStorage()
        {
            var jerry = new Inmates { Id = 0, Name = "Jerry", IsMember = true, Interests = Interests.EatingCheezItsByTheBox, Services = new Services { Type = ServiceType.SnuggleBuddy }, Gender = Inmates.Sex.Male };
            var penelope = new Inmates { Id = 1, Name = "Penelope", IsMember = true, Interests = Interests.HeavyBreathing, Services = new Services { Type = ServiceType.Smuggler }, Gender = Inmates.Sex.Female };
            var rob = new Inmates { Id = 2, Name = "Rob", IsMember = true, Interests = Interests.EatingCheezItsByTheBox, Services = new Services { Type = ServiceType.Smuggler }, Gender = Inmates.Sex.Female };
            var duck = new Inmates { Id = 3, Name = "Duck", IsMember = true, Interests = Interests.InterpretiveDance, Services = new Services { Type = ServiceType.Smuggler}, Gender = Inmates.Sex.Female };

            jerry.Enemies.Add(rob);

            jerry.Friends.Add(penelope);
            jerry.Friends.Add(duck);
            penelope.Friends.Add(jerry);
            rob.Friends.Add(duck);
            duck.Friends.Add(rob);

            _inmates.Add(jerry);
            _inmates.Add(penelope);
            _inmates.Add(duck);
            _inmates.Add(rob);
        }



        public void CreateInmate(Inmates inmates)
        {
            int counter = 3;
            inmates.Id = counter + 1;
            counter += 1;
            _inmates.Add(inmates);
        }

        internal Inmates GetInmateById(int id)
        {
            return _inmates.Find(inmate => inmate.Id == id);
        }

        public IEnumerable<Inmates> GetAllInmates()
        {
            return _inmates;
        }
    }
}
