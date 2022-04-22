using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Battery
    {
        public int Id { get; set; }

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
        public int building_id { get; set; }
        public int employee_id { get; set; }
        public Building building { get; set; }
        public List <Column> column { get; set; }
     
    }
}