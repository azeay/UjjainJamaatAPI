using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Miqaats.DTOs
{
    public class MiqaatDto : EntityDto
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
    }
}
