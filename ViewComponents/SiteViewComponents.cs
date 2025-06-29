using Microsoft.AspNetCore.Mvc;
namespace NewsSite.ViewComponents
{
    // Region site header

    #region Site Header
    public class SiteHeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SiteHeader");

        }
    }
    #endregion

    #region Site Footer
    public class SiteFooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SiteFooter");

        }
    }
    #endregion

}