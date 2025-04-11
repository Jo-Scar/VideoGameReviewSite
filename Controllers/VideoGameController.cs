using Microsoft.AspNetCore.Mvc;

namespace VideoGameReviewSite.Controllers
{
    public class VideoGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
