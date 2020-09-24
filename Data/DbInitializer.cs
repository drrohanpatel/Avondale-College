using Avondale_College.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avondale_College.Data
{
    public class DbInitializer
    {
        public static void Initialize(AvondaleCollegeContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
            var students = new Student[]
            {
                new Student{Firstname="Barry",Lastname="Allen",Email="ac98853@avcol.school.nz",HomeroomClass="D15",YearLevel="12"},
                new Student{Firstname="David",Lastname="Favier",Email="ac93223@avcol.school.nz",HomeroomClass="D5",YearLevel="12"},
                new Student{Firstname="Rohan",Lastname="Patel",Email="ac94553@avcol.school.nz",HomeroomClass="A23",YearLevel="12"},
                new Student{Firstname="Oluver",Lastname="Queen",Email="ac98563@avcol.school.nz",HomeroomClass="C5",YearLevel="11"},
                new Student{Firstname="John",Lastname="Cena",Email="ac50853@avcol.school.nz",HomeroomClass="A15",YearLevel="13"}

            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            var teacher = new Teacher[]
            {
                new Teacher{Firstname="John",Lastname="Cena",Email="JOH@avcol.school.nz",DepartmentArea="English"},
                new Teacher{Firstname="Jeff",Lastname="Daniel",Email="DAN@avcol.school.nz",DepartmentArea="Maths"},
                new Teacher{Firstname="Terry",Lastname="Brown",Email="TER@avcol.school.nz",DepartmentArea="Science"},
                new Teacher{Firstname="Joseph",Lastname="Bhai",Email="BAH@avcol.school.nz",DepartmentArea="Social Science"},
                new Teacher{Firstname="Vijay",Lastname="Prasad",Email="PSV@avcol.school.nz",DepartmentArea="Information and Communication Technology"}
            };
            foreach (Teacher c in teacher)
            {
                context.Teachers.Add(c);
            }
            context.SaveChanges();

            var Department = new Department[]
            {
                new Department{DepartmentName="English",DepartmentDirector="John Cena",Email="JOH@avcol.school.nz"},
                new Department{DepartmentName="Maths",DepartmentDirector="Jeff Danile",Email="DAN@avcol.school.nz"},
                new Department{DepartmentName="Information and Communication Technology",DepartmentDirector="Vijay Prasad",Email="pvs@avcol.school.nz" }

            };
            foreach(Department e in Department)
            {
                context.Departments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
