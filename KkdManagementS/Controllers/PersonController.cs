using KkdManagementS.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace KkdManagementS.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.greeting = "Hello klugah";
            ViewData["greeting2"] = "Hello I am a male!";
            //viewdata and viewbag can send data only from ControllerToView



            //Tempdata can send message from one controller method to another controller method.
            //it can also be used like the viewbag and viewdata.
            TempData["greeting3"] = "I am 22 years of age";
            return View();
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            return View();
        }
    }
}
