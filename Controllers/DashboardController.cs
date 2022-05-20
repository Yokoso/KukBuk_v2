using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace KukBuk.Controllers
{
    public class DashboardController : Controller
    {
        // GET: /Dashboard/
        public IActionResult Index() 
        {
            return View();
        }

        // GET: /Dashboard/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}