using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                TempData[ErrorMessage] = "شما قبلا وارد شده اید ";
                return Redirect("/");
            }
            return View();
        }

        [HttpPost("Login"), ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVieModel login)
        {
            var res = await _userService.LoginUser(login);
            switch (res)
            {
                case LoginResult.NotFound:
                    TempData[ErrorMessage] = "کاربری با این مشخضات پیدا نشد";
                    break;
                case LoginResult.Error:
                    TempData[ErrorMessage] = "ایمیل وارد شدخ تکراری است";
                    break;
                case LoginResult.Success:
                   var user = await _userService.GetUserByEmail(login.Email);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name , user.UserName),
                        new Claim(ClaimTypes.Email , user.Email),
                        new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                    };
                    var identity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);
                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.
                        AuthenticationScheme, new ClaimsPrincipal(identity), properties);
                    TempData[SuccessMessage] = "login ok ";
                    return Redirect("/");
                   
            }
            return View(login) ;
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



        #region LogOut
        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated) return Redirect("/");
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            TempData[InfoMessage] = "log out is ok ";
            return Redirect("/");
        }
        #endregion
    }
}
