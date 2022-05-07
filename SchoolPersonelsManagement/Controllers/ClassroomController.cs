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
    public class ClassroomController : Controller
    {
        private readonly SchoolContext _db;

        public ClassroomController(SchoolContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Classroom> classrooms = _db.Classrooms;
            return View(classrooms);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateClassroom(Classroom classroom)
        {
          
            _db.Classrooms.Add(classroom);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            StudentAndClassViewModel studentAndClassViewModel = new StudentAndClassViewModel();

            //studentAndClassViewModel.students = _db.Students.ToList();
            //studentAndClassViewModel.classrooms = _db.Classrooms.ToList();
            //return View(studentAndClassViewModel);

            studentAndClassViewModel.classroom = _db.Classrooms.Find(id);
            studentAndClassViewModel.students = _db.Students.ToList();
            return View(studentAndClassViewModel);


            //var DetailClassrom = _db.Classrooms.Find(id);
            //return View(DetailClassrom);
        }
        public IActionResult Delete(int Id)
        {
            var DeletedClassroom = _db.Classrooms.Find(Id);
            _db.Classrooms.Remove(DeletedClassroom);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //public IActionResult addStudentToClassroom(int id)
        //{
        //    var createNewStudent = _db.Classrooms.Find(id);
        //    return View
        //}
    }
}
