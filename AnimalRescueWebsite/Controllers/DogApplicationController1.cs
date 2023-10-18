using AnimalRescueWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalRescueWebsite.Controllers
{
    public class DogApplicationController1 : Controller
    {
        public IActionResult Apply(int id)
        {
            return View();
        }
    }
}
