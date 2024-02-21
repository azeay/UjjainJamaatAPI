using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Models
{

    public class MiqaatFloor:Entity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool isGenerated { get; set; }
        public int MiqaatId { get; set; }
        public Miqaat Miqaat { get; set; }
        public int FloorId { get; set; }
        public Floor Floor { get; set; }
    }
}
