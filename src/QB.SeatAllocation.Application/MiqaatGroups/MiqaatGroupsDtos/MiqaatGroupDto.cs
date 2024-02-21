using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.MiqaatGroups.MiqaatGroupsDto
{
    public class MiqaatGroupDto:EntityDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
