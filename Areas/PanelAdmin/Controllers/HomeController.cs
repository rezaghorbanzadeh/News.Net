using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.PanelAdmin.Controllers
{

    public class HomeController : AdminPanelController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
