using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Controllers
{
    public class PostController : Controller
    {

        #region Constructor
        #endregion


        #region Posts Filter
        [HttpGet("PostsFilter")]
        public IActionResult PostsFilter()
        {
            return View();
        }
        #endregion


        #region Posts Details
        [HttpGet("PostsDetails")]
        public IActionResult PostsDetails()
        {
            return View();
        }
        #endregion

    }
}
