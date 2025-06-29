using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.PanelAdmin.Controllers
{

    [Area("AdminPanel")]
    [Route("Panel")]
    [Authorize]
    public class AdminPanelController : Controller
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string ErrorMessage = "ErrorMessage";
        protected string WarningMessage = "WarningMessage";
        protected string InfoMessage = "InfoMessage";
    }
}
