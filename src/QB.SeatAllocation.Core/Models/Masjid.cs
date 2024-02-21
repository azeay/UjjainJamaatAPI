using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Models
{
    public class Masjid: Entity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
      
        //public string City { get; set; }
    }
}
