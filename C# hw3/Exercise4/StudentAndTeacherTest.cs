using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person p1 = new Person();
            p1.Hello();
            Student s1 = new Student();
            s1.SetAge(21);
            s1.ShowAge();
            Teacher t1 = new Teacher();
            t1.Hello();
            t1.Explain();
        }
    }
}
