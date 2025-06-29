using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Controllers
{

    public class AccountingController : Controller
    {

        #region Constructor

        #endregion

        #region Register
        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }
        #endregion


        #region Login
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        #endregion


        #region ForgetPassword
        [HttpGet("ForgetPassword")]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        #endregion


        #region ResetPassword
        [HttpGet("ResetPassword")]
        public IActionResult ResetPassword()
        {
            return View();
        }
        #endregion
    }
}
