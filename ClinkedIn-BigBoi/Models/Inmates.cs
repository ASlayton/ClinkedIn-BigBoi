using System;
using System.Collections.Generic;
using System.Text;

namespace ClinkedIn_BigBoi.Models
{
    public class Inmates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Services Services { get; set; }
        public Interests Interests { get; set; }
        public bool IsMember { get; set; }

    }
}
