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
    public class StudentController : Controller
    {
        private readonly SchoolContext _db;

        public StudentController(SchoolContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> students = _db.Students;
            return View(students);
        }
        [HttpGet]
        public IActionResult CreateStudent()
        {
            StudentAndClassViewModel studentAndClassViewModel = new StudentAndClassViewModel();

            studentAndClassViewModel.students = _db.Students.ToList();
            studentAndClassViewModel.classrooms = _db.Classrooms.ToList();
            return View(studentAndClassViewModel);
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.classroom = _db.Classrooms.Find(student.classroom.Id);
            _db.Students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var DeletedStudent = _db.Students.Find(id);
            _db.Remove(DeletedStudent);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            StudentAndClassViewModel studentAndClassViewModel = new StudentAndClassViewModel();

            studentAndClassViewModel.Student = _db.Students.Find(id);
            studentAndClassViewModel.classrooms = _db.Classrooms.ToList();
            return View(studentAndClassViewModel);

        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            var updatedStudent = _db.Students.SingleOrDefault(s=> s.Id == student.Id);
            updatedStudent.FullName = student.FullName;
            updatedStudent.ImgUrl = student.ImgUrl;
            updatedStudent.classroom = _db.Classrooms.Find(student.classroom.Id);
            _db.Students.Update(updatedStudent);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
