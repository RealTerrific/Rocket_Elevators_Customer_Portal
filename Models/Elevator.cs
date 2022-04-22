using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Elevator
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string BuildingType { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommissionDate { get; set; }
        public DateTime LastInspectionDate { get; set; }
        public string Certificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int column_id { get; set; }
        public Column column { get; set; }
     
    }
}