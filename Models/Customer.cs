using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyDescription { get; set; }
        public string TechAuthorityName { get; set; }
        public string TechAuthorityPhone { get; set; }
        public string TechAuthorityEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // public List <EmailAddr { get; set; }
        // public int UserID { get; set; }
        public List<Building> buildings { get; set; }
        
    
     
    }
}