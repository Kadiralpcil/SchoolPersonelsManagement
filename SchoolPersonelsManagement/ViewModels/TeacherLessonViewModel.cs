using SchoolPersonelsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.ViewModels
{
    public class TeacherLessonViewModel
    {
        public List<int> lessons { get; set; } 
        public List<Teacher> teachers { get; set; }
        public Lesson lesson { get; set; }
        public Teacher Teacher{ get; set; }
    }
}
