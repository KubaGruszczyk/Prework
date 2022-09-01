using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Prework
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Hello, World!");

            //Task 2
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Task 2");
            Console.WriteLine("Hello Jakub!");

            //Task 3
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Task 3");
            var name = "Jakub";
            Console.WriteLine("Hello " + name + "!");

            //Task 4
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Task 4");
            var user_name = "Jakub";
            Console.WriteLine($"Hello {user_name}!");

            //Task 5
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Task 5");
            var username = "Jakub";
            Console.WriteLine($"Hello {username.ToUpper()}!");

            //Task 6
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Task 6");
            var names = new[] { "Jakub", "Szymon", "Artur" };
            foreach (var user in names)
            {
                Console.WriteLine($"Hello {user}!");
            }
        }
    }
}




