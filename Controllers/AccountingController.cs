using Microsoft.AspNetCore.Mvc;

using NewsSite.Services.Interface;
using NewsSite.ViewsModels.Account;

namespace NewsSite.Controllers
{

    public class AccountingController : NotificationController
    {

        #region Constructor

        private readonly IUserService _userService;

        public AccountingController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                TempData[ErrorMessage] = "شما قبلا وارد شده اید ";
                return Redirect("/");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
                                                    

        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            Console.WriteLine(register);
            if (ModelState.IsValid)
            {
                var res = await _userService.RegisterUser(register);
                switch (res)
                {
                    case RegisterResult.EmailExsist:
                        TempData[ErrorMessage] = "ایمیل وارد شدخ تکراری است";
                        break;
                    case RegisterResult.Error:
                        TempData[ErrorMessage] = "ایمیل وارد شدخ تکراری است";
                        break;
                    case RegisterResult.Success:
                        TempData[ErrorMessage] = "ایمیل وارد شدخ تکراری است";
                        return Redirect("Login");

                }
            }
            return View(register);
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
