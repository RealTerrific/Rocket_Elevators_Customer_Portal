using CustomerPortal.Models;

namespace CustomerPortal.ViewModels
{
    public class HomeIntervention
    {
        public int TestField1 {get;set;}
        public string TestField2 {get;set;}
        public Customer intcustomers {get;set;}
        public List<Building> intbuildings {get;set;}
        public List<Battery> intbatteries {get;set;}
        public List<Column> intcolumns {get;set;}
        public List<Elevator> intelevators {get;set;}
        public List<Employee> intemployees {get;set;}
    }
}
