using System;
using System.Collections.Generic;
using System.Text;

namespace ClinkedIn_BigBoi.Models
{
    public class Services
    {
        public string ServiceType Type { get; set; }
    public string Fees { get; set; }
}

public enum ServiceType
{
    Protector,
    Haberdasher,
    Assassin,
    SnuggleBuddy,

}
}
