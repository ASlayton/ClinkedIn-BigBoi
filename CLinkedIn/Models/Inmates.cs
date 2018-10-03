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
        public Services Services { get; set; }
        public Sex Gender { get; set; }

        public enum Sex
        {
            Male, Female
        }

    }
}
