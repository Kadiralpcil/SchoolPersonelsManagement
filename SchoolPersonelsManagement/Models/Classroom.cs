using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Models
{
    public class Classroom
    {
        public Classroom()
        {
            Students = new List<Student>();
        }

        public int Id { get; set; }
        public String ClassName { get; set; }
        public int ClassNumber { get; set; }
        public Teacher ClassMainTeacher { get; set; }
        public List<Student> Students { get; set; }   
    }
}
