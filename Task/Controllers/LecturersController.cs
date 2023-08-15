using Microsoft.AspNetCore.Mvc;

namespace IS_Task.Controllers
{
    public class LecturersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
