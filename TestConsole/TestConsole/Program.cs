using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestConsole
{


    public delegate void PrintDelegate(int value);
    public delegate void MathDelegate(int first, int second);
    public delegate void ToStringDelegate(Object obj1);

    class Program
    {
       
        private static void Main(string[] args)
        {
            //ConnectAzureRepos();

            ToStringDelegate toString = PrintToString;

            Student Biggo = new Student("Biggo");
            Dog Bingo = new Dog(45);


            toString(Bingo);
            toString(Biggo);


            PrintDelegate delegatedPrint = PrintInt;

            delegatedPrint(32);


            delegatedPrint = PrintMoney;

            //can also be called with the Invoke Method
            delegatedPrint.Invoke(45);

            PrintHelper(delegatedPrint,7000);
            delegatedPrint = PrintInt;
            PrintHelper(delegatedPrint,7000);

            //multicast delegates
            PrintDelegate multiPrintDelegate = PrintInt;
            multiPrintDelegate += PrintMoney;
            multiPrintDelegate += PrintHexadecimal;

            //call the delegate and all the methods associated with it
            multiPrintDelegate(500);

            //multiCast multiplication
            MathDelegate delegatedMath = Add;
             delegatedMath += Subtract;
             delegatedMath += Multiply;
             delegatedMath += Divide;

             delegatedMath(500, 2);

             PairDelegate();


            Console.ReadLine();
        }

        private static void PairDelegate()
        {
//practice with Delegates
            //CREATE     TWO Students and two dogs

            Student Jesse = new Student("Jesse");
            Student Stacey = new Student("Stacey");

            Dog Milo = new Dog(50);
            Dog Fred = new Dog(56);

            Pair theStudentPair = new Pair(Jesse, Stacey);
            Pair theDogPair = new Pair(Milo, Fred);

            Console.WriteLine($"student pair {theStudentPair}");
            Console.WriteLine($"the dog pair {theDogPair}");


            //Instantiate the delegates
            Pair.WhichIsFirst theStudentDelegate = new Pair.WhichIsFirst(Student.WhichStudentComesFirst);
            Pair.WhichIsFirst theDogDelegate = new Pair.WhichIsFirst(Dog.WhichDogComesFirst);

            //sort using the delegates

            theStudentPair.Sort(theStudentDelegate);
            theDogPair.Sort(theDogDelegate);

            Console.WriteLine($"After Sort the student pair {theStudentPair}");
            Console.WriteLine($"After Sort the dog pair {theDogPair}");


            theStudentPair.ReverseSort(theStudentDelegate);
            theDogPair.ReverseSort(theDogDelegate);

            Console.WriteLine($"After  Reverse Sort the student pair {theStudentPair}");
            Console.WriteLine($"After Reverse Sort the dog pair {theDogPair}");


            Pair theEmployeePair = new Pair(new Employee(2), new Employee(4));

            Pair.WhichIsFirst theEmpDelegate = new Pair.WhichIsFirst(Employee.WhichEmployeeComesFirst);

            theEmployeePair.Sort(theEmpDelegate);

            //create the delegate for reversing the name
            Pair.ReverseMyName reverseDelegateStudent = new Pair.ReverseMyName(Student.ReverseName);
            Pair.ReverseMyName reverseDelegateEmployee = new Pair.ReverseMyName(Employee.ReverseName);


            theStudentPair.ReverseObject(reverseDelegateStudent);

            theEmployeePair.ReverseObject(reverseDelegateEmployee);
        }


        private static void PrintToString(object obj1)
        {
            Console.WriteLine(obj1.ToString());
        }

        //https://www.tutorialsteacher.com/csharp/csharp-delegates
        private static void PrintHelper(PrintDelegate dPrintDelegate, int value)
        {
            dPrintDelegate(value);
        }

        private static void PrintInt(int value)
        {
            Console.WriteLine($" the value is: {value}");
        }

        private static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        private static void Add(int first, int second)
        {
            int number = first + second;
            Console.WriteLine("Number: {0,-12:N0}",number);
        }

        private static void Subtract(int first, int second)
        {
            int number = first - second;
            Console.WriteLine("Number: {0,-12:N0}",number);
        }

        private static void Multiply(int first, int second)
        {
            int number = first * second;
            Console.WriteLine("Number: {0,-12:N0}",number);
        }
        private static void Divide(int first, int second)
        {
            int number = first / second;
            Console.WriteLine("Number: {0,-12:N0}",number);
        }

        private static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

  }
}
