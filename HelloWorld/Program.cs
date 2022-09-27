using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("shhtdgy");
            Emp employe1 = new Emp { ID = 101, Name = "dd", Salary = 39234523 };
            Console.WriteLine($"{employe1.Salary}, {employe1.Name}");

            Console.WriteLine("this is tuesday");
            


        }
    }
}
