using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Models
{
    public class TeacherClassroom
    {
        public int Id { get; set; }
        public Classroom Classroom { get; set; }
        public Teacher Teacher { get; set; }
    }
}
