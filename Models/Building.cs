using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Building
    {
        public int Id { get; set; }

        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPhone { get; set; }
        public string TechName { get; set; }
        public string TechEmail { get; set; }
        public string TechPhone { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int customer_id { get; set; }
        public Customer customer { get; set; }
        public List <Battery> batteries { get; set; }
        // public List <Address> addresses { get; set; }
     
    }
}