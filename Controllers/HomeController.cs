using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomerPortal.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using CustomerPortal.ViewModels;

namespace CustomerPortal.Controllers;



public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    // [Authorize]
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult Login(){

        return View("Index", "Home");
    }

    

    public IActionResult Logout(){

            return View("Index", "Home");
    }

     public IActionResult Products()
    {
        return View();
    }

    // public IActionResult Intervention()
    // {
    //     return View();
    // }

    // This will get all the batteries for a Customer based on the CustomerId using the REST API and the endpoint created.
        public IActionResult BatteriesList(string email)
        {
            // http response for batteries
            HttpClient batteryclient = new HttpClient();
            var restbattery = batteryclient.GetStringAsync("https://rocket-elevators-rest-2022.herokuapp.com/api/Batteries/Buildings/1").GetAwaiter().GetResult();
            Console.WriteLine(restbattery);

            List<Battery> batt = JsonConvert.DeserializeObject<List<Battery>>(restbattery);

            ViewBag.batteries = batt;

            return View();
        }

        // This will get all the columns for a Customer based on the CustomerId using the REST API and the endpoint created.
        public IActionResult ColumnsList()
        {
            HttpClient columnclient = new HttpClient();
            var restcolumn = columnclient.GetStringAsync("https://rocket-elevators-rest-2022.herokuapp.com/api/Columns/Batteries/1").GetAwaiter().GetResult();
            Console.WriteLine(restcolumn);

            List<Column> col = JsonConvert.DeserializeObject<List<Column>>(restcolumn);

            ViewBag.columns = col;

            return View();
        }

        // This will get all the elevators for a Customer based on the CustomerId using the REST API and the endpoint created.
        public IActionResult ElevatorsList()
        {
            HttpClient elevatorclient = new HttpClient();
            var restelevator = elevatorclient.GetStringAsync("https://rocket-elevators-rest-2022.herokuapp.com/api/Elevators/Columns/1").GetAwaiter().GetResult();
            Console.WriteLine(restelevator);

            List<Elevator> elev = JsonConvert.DeserializeObject<List<Elevator>>(restelevator);

            ViewBag.elevators = elev;

            return View();
        }

        // This will get all the products of a Customer based on the CustomerId using the REST API and the endpoint created.
        // [Authorize]
        public IActionResult Intervention()
        {
            HomeIntervention homeIntervention = new HomeIntervention();
            // homeIntervention.TestField1 = 16;
            // homeIntervention.TestField2 = "Howdy!";

            HttpClient customerclient = new HttpClient();
            var restcustomer = customerclient.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/customers/1").GetAwaiter().GetResult();
            Console.WriteLine(restcustomer);
            
            Customer interventionCustomer = JsonConvert.DeserializeObject<Customer>(restcustomer);

            
            homeIntervention.intcustomers = interventionCustomer;

            // This gets the buildings of the customer
            HttpClient client = new HttpClient();
            var restbuilding = client.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/buildings/buildbycustomers/5").GetAwaiter().GetResult();
            // Console.WriteLine(restbuilding);

            List<Building> interventionBuilding = JsonConvert.DeserializeObject<List<Building>>(restbuilding);

            
            homeIntervention.intbuildings = interventionBuilding;
            

            // This gets the batteries of the customer

            HttpClient batteryclient = new HttpClient();
            var restbattery = batteryclient.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/batteries/batterybybuilding/5").GetAwaiter().GetResult();
            // Console.WriteLine(restbattery);

            List<Battery> interventionBattery = JsonConvert.DeserializeObject<List<Battery>>(restbattery);

            homeIntervention.intbatteries = interventionBattery;

            // This gets the columns of the customer

            HttpClient columnclient = new HttpClient();
            var restcolumn = columnclient.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/columns/columnbybattery/5").GetAwaiter().GetResult();
            // Console.WriteLine(restcolumn);

            List<Column> interventionColumn = JsonConvert.DeserializeObject<List<Column>>(restcolumn);

            homeIntervention.intcolumns = interventionColumn;

            // This gets the elevators of the customer

            HttpClient elevatorclient = new HttpClient();
            var restelevator = elevatorclient.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/elevators/elevatorbycolumn/6").GetAwaiter().GetResult();
            // Console.WriteLine(restelevator);

            List<Elevator> interventionElevator = JsonConvert.DeserializeObject<List<Elevator>>(restelevator);

            homeIntervention.intelevators = interventionElevator;

            // return View();


            // This gets the employees
            HttpClient emplclient = new HttpClient();
            var restemployee = elevatorclient.GetStringAsync("https://wocket-elevators-rest-api.herokuapp.com/api/employees").GetAwaiter().GetResult();
            // Console.WriteLine(restemployee);

            List<Employee> interventionEmployee = JsonConvert.DeserializeObject<List<Employee>>(restemployee);

            homeIntervention.intemployees = interventionEmployee;

            return View(homeIntervention);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
