using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.PanelAdmin.Controllers
{
    public class UserController : Controller
    {
        #region Constructor

        #endregion

        #region User List
        [HttpGet("Panel/UserList")]
        public IActionResult PostList()
        {
            return View();
        }
        #endregion  
    }
}
