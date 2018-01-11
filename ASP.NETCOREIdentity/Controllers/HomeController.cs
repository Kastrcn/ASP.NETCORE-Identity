using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREIdentity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Placeholder", "Placeholder");
            return View(data);
        }


    }
}
