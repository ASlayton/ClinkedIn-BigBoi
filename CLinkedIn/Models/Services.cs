using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLinkedIn.Models
{
    public class Services
    {
        public string Fees { get; set; }
        public ServiceType Type { get; set; }
    }

    public enum ServiceType
    {
        Haberdasher,
        Protector,
        Assassin,
        SnuggleBuddy,
        Smuggler,
        Priest,
        Tattooist,
        Hairdresser,
        Trainer,
        Snitch,
        Mama
    }
}
