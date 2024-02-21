using Abp.Application.Services.Dto;
using QB.SeatAllocation.Floors.DTOs;
using QB.SeatAllocation.Miqaats.DTOs;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.MiqaatFloors.MiqaatFloorDtos
{
    public class MiqaatFloorDto: EntityDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool isGenerated { get; set; }
        public int MiqaatId { get; set; }
        public MiqaatDto Miqaat { get; set; }
        public int FloorId { get; set; }
        public FloorDto Floor { get; set; }
    }
}
