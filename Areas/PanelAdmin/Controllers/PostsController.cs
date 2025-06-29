using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.PanelAdmin.Controllers
{
    public class PostsController : AdminPanelController
    {
        #region Constructor

        #endregion

        #region PostList
        [HttpGet("Panel/PostList")]
        public IActionResult PostList()
        {
            return View();
        }
        #endregion  
        
        
        #region Create Post
        [HttpGet("Panel/CreatePost")]
        public IActionResult CreatePost()
        {
            return View();
        }
        #endregion
        
        #region Edit Post
        [HttpGet("Panel/EditPost")]
        public IActionResult EditPost()
        {
            return View();
        }
        #endregion   
        
        #region Delete Post
        [HttpGet("Panel/DeletePost")]
        public IActionResult DeletePost()
        {
            return View();
        }
        #endregion
    }
}
