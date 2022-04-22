using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string BuildingType { get; set; }
        public int NumberFloorsServed { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int battery_id { get; set; }
        public List<Elevator> elevators { get; set; }
        public Battery battery { get; set; }
     
    }
}