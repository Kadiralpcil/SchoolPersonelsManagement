using Microsoft.EntityFrameworkCore;
using SchoolPersonelsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Data
{
    public class SchoolContext : DbContext
    { 
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Classroom> Classrooms{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Management> Managements{ get; set; }
        public DbSet<TeacherClassroom> TeacherClassrooms{ get; set; }
        public DbSet<TeacherLesson> TeacherLessons { get; set; }
    }
}
