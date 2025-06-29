using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class HomeController : NotificationController
    {
        #region Home   
        public IActionResult index()
        {
            return View();
        }
        #endregion


        #region About Us
        [HttpGet("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }
        #endregion


        #region contact Us
        [HttpGet("contactUs")]
        public IActionResult contactUs()
        {
            return View();
        }
        #endregion
    }
}
