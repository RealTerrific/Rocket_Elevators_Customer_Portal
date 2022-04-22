using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // public int UserID { get; set; }
   
    }
}