using System;
using System.Collections.Generic;
using System.Text;
using CLinkedIn.Models;

namespace CLinkedIn.DataAccess
{
    public class InmateStorage
    {
        static List<Inmates> _inmates = new List<Inmates>()
        {
            new Inmates { Id = 0, Name = "Jerry", IsMember = true, Interests = Interests.EatingCheezItsByTheBox, PersonalServices = new Services { Type = ServiceType.Haberdasher, Fees = FeeType.fourBottleCap }, Gender = Inmates.Sex.Male },
            new Inmates { Id = 1, Name = "Penelope", IsMember = true, Interests = Interests.HeavyBreathing, PersonalServices = new Services { Type = ServiceType.Smuggler, Fees = FeeType.oneBottlecap }, Gender = Inmates.Sex.Female },
            new Inmates { Id = 2, Name = "Rob", IsMember = true, Interests = Interests.EatingCheezItsByTheBox, PersonalServices = new Services { Type = ServiceType.Assassin, Fees = FeeType.threeBottleCap }, Gender = Inmates.Sex.Female },
            new Inmates { Id = 3, Name = "Duck", IsMember = true, Interests = Interests.InterpretiveDance, PersonalServices = new Services { Type = ServiceType.Smuggler, Fees = FeeType.oneBottlecap }, Gender = Inmates.Sex.Female },
        };

        public void CreateInmate(Inmates inmates)
        {         
            int counter = 3;
            inmates.Id = counter + 1;
            counter += 1;
            _inmates.Add(inmates);
        }

        public IEnumerable<Inmates> GetAllInmates()
        {
            return _inmates;
        }

        public Inmates GetInmateById(int id)
        {
            return _inmates.Find(inmate => inmate.Id == id);
        }

        public void DeleteAConvict(int id)
        {
            _inmates.RemoveAll(inmate => inmate.Id == id);
        }

    }
}
