using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Models
{
    public class TeacherLesson
    {
        public int Id { get; set; }
        public Lesson Lesson { get; set; }
        public Teacher Teacher { get; set; }
    }
}
