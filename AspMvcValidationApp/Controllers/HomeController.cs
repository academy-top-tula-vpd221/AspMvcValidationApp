using AspMvcValidationApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcValidationApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Employee() => View();

        [HttpPost]
        public string Employee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                string str = $"Name {employee.Name}, Age: {employee.Age}\n";
                
                foreach(var item in ModelState)
                {
                    str += item.Key + " -> ";
                    str += item.Value.ValidationState + "\n";
                }
                return str;
            }
            else
            {
                string str = "Not validation\n";

                foreach (var item in ModelState)
                {
                    str += item.Key + " -> ";
                    str += item.Value.ValidationState + "\n";
                }
                return str;
            }

        }
    }
}
