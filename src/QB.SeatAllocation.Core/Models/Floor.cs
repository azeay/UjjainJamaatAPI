

using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Models
{
    public class Floor: Entity
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
