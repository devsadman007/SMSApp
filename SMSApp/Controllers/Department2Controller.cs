using Microsoft.AspNetCore.Mvc;

namespace SMSApp.Controllers
{
    public class Department2Controller : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
