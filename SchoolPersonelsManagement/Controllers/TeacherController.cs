using Microsoft.AspNetCore.Mvc;
using SchoolPersonelsManagement.Data;
using SchoolPersonelsManagement.Models;
using SchoolPersonelsManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Controllers
{
    public class TeacherController : Controller
    {
        private readonly SchoolContext _db;

        public TeacherController(SchoolContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            TeacherLessonViewModel teacherLessonViewModel = new TeacherLessonViewModel();

            ViewBag.Lessons = _db.Lessons.ToList();
            teacherLessonViewModel.teachers = _db.Teachers.ToList();
            return View(teacherLessonViewModel);
        }
        [HttpPost]
        public IActionResult Create(TeacherLessonViewModel saveTeacherAndLesson)
        {
            Teacher teacher = new Teacher();
            teacher.FullName = saveTeacherAndLesson.Teacher.FullName;
            teacher.ImgUrl = saveTeacherAndLesson.Teacher.ImgUrl;
            _db.Teachers.Add(teacher);

            saveTeacherAndLesson.lessons.ForEach(Lesson =>
            {
                TeacherLesson teacherLesson = new TeacherLesson();
                teacherLesson.Teacher = teacher;
                teacherLesson.Lesson = _db.Lessons.FirstOrDefault(les => les.Id == Lesson);
                _db.TeacherLessons.Add(teacherLesson);
            });
            _db.SaveChanges();
            return RedirectToAction("index");


        }
    }
}
