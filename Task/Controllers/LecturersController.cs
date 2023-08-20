using IS_Task.Data;
using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace IS_Task.Controllers
{
    public class LecturersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LecturersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List <LecturerModel> objLecturersList  = _db.Lecturers.ToList();
            return View(objLecturersList);
        }
               public IActionResult Create()
        {
            return View();
        }
    }
}
