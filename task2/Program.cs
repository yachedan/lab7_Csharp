using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student{Name = "Don Quixote",Course = 2, Mark = 4};
            var paidStudent1 = new PaidStudent{Name = "Sancho Panza", Course = 1,Mark = 4,Paid = true};
            var paidStudent2 = new PaidStudent{Name = "Wilfred of Ivanhoe", Course =3,Mark = 2, Paid = false};
            var graduate = new GradStudent{Name = "Beowulf", Course = 3,Mark = 4,headName="Grendel"};
            Console.WriteLine(student.Info()+paidStudent1.Info()+paidStudent2.Info()+graduate.Info());
            student.NextCourse();
            paidStudent1.NextCourse();
            paidStudent2.NextCourse();
            graduate.NextCourse();
            Console.WriteLine(student.Info() + paidStudent1.Info() + paidStudent2.Info() + graduate.Info());
        }
    }
}
