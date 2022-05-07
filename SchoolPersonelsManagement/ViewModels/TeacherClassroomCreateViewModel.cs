using SchoolPersonelsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.ViewModels
{
    public class TeacherClassroomCreateViewModel
    {
        public Teacher Teacher{ get; set; }
        public Classroom Classroom{ get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Classroom> Classrooms{ get; set; }

    }
}
