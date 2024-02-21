using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Models
{
    public class MiqaatGroup: Entity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
