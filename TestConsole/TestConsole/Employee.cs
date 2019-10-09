using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
   public class Employee
    {

        private int rank;

        public Employee(int rank)
        {
            this.rank = rank;
        }

        public override string ToString()
        {
            return rank.ToString().ToLower();
        }

        /// <summary>
        /// Employees are sorted according to their weight
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static Comparison WhichEmployeeComesFirst(Object o1, Object o2)
        {
            Employee s1 = (Employee) o1;
            Employee s2 = (Employee) o2;

            return s1.rank < s2.rank
                ? Comparison.TheFirstComesFirst
                : Comparison.TheSecondComesFirst;
        }

        public static string ReverseName(Object o1)
        {
            Employee d1 = (Employee) o1;

            string reverseName =  new string(d1.ToString().Reverse().ToArray());

            return reverseName;
        }
    }
}
