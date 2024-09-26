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
        [HttpPost]
        public IActionResult Create(LecturerModel obj)
        {
           if(ModelState.IsValid) { 
            _db.Lecturers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            LecturerModel lecturersFromDb = _db.Lecturers.Find(id);
            if (lecturersFromDb == null)
            {
                return NotFound();
            }
            return View(lecturersFromDb);
        }
        [HttpPost]
        public IActionResult Edit(LecturerModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Lecturers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
