using System;
using System.Collections.Generic;
using System.Text;
using CLinkedIn.Models;


namespace CLinkedIn.Models
{
    public class Inmates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMember { get; set; }
        public Interests Interests { get; set; }
        public Services PersonalServices { get; set; }
        public Sex Gender { get; set; }
        //public List<Services> PersonalServices { get; set; } = new List<Services>();
        public enum Sex
        {
            Male, Female
        }
    }
}
