using Microsoft.AspNetCore.Mvc;
using SchoolPersonelsManagement.Data;
using SchoolPersonelsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Controllers
{
    public class LessonController : Controller
    {
        private readonly SchoolContext _db;

        public LessonController(SchoolContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Lesson> lessons = _db.Lessons;
            return View(lessons);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Lesson lesson)
        {
            _db.Lessons.Add(lesson);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
