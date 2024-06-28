using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }
        public IActionResult BlogIndex()
        {
            return View();
        }

        public IActionResult BlogJoin()
        {
            return View();
        }


    }
}
