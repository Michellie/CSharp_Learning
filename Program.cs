using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            Console.Write("Type your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
