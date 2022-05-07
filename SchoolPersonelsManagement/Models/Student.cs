using SchoolPersonelsManagement.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Models
{
    public class Student : BaseModel
    {
        public Classroom classroom { get; set; }
    }
}
