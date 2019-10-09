using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"The Students name is {name.ToLower()}";
        }


        /// <summary>
        /// Students are sorted according to their name
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static Comparison WhichStudentComesFirst(Object o1, Object o2)
        {
            Student s1 = (Student) o1;
            Student s2 = (Student) o2;

            return (string.Compare(s1.name, s2.name) < 0
                ? Comparison.TheFirstComesFirst
                : Comparison.TheSecondComesFirst);
        }

        public static string ReverseName(Object o1)
        {
            Student d1 = (Student) o1;

            string reverseName =  new string(d1.ToString().Reverse().ToArray());

            return reverseName.ToLower();
        }
    }
}
