using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.PanelAdmin.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
