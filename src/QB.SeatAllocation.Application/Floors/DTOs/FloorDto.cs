using Abp.Application.Services.Dto;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Floors.DTOs
{
    public class FloorDto: EntityDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public int RowCount { get; set; }
        public int ColumnCount { get; set; }

        public int ZoneCount { get; set; }
        public string RowInitials { get; set; }
        public string ColumnInitials { get; set; }
        public int MasjidId { get; set; }
        public Masjid Masjid { get; set; }
    }
}
