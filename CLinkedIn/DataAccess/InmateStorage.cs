using System;
using System.Collections.Generic;
using System.Text;
using CLinkedIn.Models;

namespace CLinkedIn.DataAccess
{
    class InmateStorage
    {
        static List<Inmates> _inmates = new List<Inmates>();

        public int counter = 0;

        public void CreateInmate(Inmates inmates)
        {         
            inmates.Id = counter + 1;
            counter += 1;
            _inmates.Add(inmates);
        }

        public Inmates GetInmateById(int id)
        {
            return _inmates.Find(inmate => inmate.Id == id);
        }
    }
}
