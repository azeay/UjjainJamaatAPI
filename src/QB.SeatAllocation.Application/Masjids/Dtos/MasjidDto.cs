using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Masjids.Dtos
{
    public class MasjidDto: EntityDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
        //public string City { get; set; }
    }
}
