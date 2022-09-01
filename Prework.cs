using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Prework
    {
        static void String_Prework()
        {
            Console.WriteLine("HELLO WORLD PREWORK !");
            Console.WriteLine("");
            //Task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Hello, World!");

            //Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2");
            Console.WriteLine("Hello Jakub!");

            //Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3");
            var name = "Jakub";
            Console.WriteLine("Hello " + name + "!");

            //Task 4
            Console.WriteLine("");
            Console.WriteLine("Task 4");
            var user_name = "Jakub";
            Console.WriteLine($"Hello {user_name}!");

            //Task 5
            Console.WriteLine("");
            Console.WriteLine("Task 5");
            var username = "Jakub";
            Console.WriteLine($"Hello {username.ToUpper()}!");

            //Task 6
            Console.WriteLine("");
            Console.WriteLine("Task 6");
            var names = new[] { "Jakub", "Szymon", "Artur" };
            foreach (var user in names)
            {
                Console.WriteLine($"Hello {user}!");
            }

        }

        static void Numbers_Prework()
        {
            Console.WriteLine("NUMBERS PREWORK !");
            Console.WriteLine("");
            Console.WriteLine("Task 1: Explore Integer math");
            int a = 18;
            int b = 6;
            Console.WriteLine($"Below Math operation for a = {a} and b = {b}");
            Console.WriteLine($"Sum a+b = {a+b}");
            Console.WriteLine($"Substraction a - b ={a-b}");
            Console.WriteLine($"Multiplication a*b = {a*b}");
            Console.WriteLine($"Division a/b = {a/b}");

            Console.WriteLine("");
            Console.WriteLine("Task 2: Explore order of operations");
            int c = 5;
            int d = 4;
            int e = 2;
            Console.WriteLine($"Below Order of operation for a = {c}, b = {d} and c ={e}");
            Console.WriteLine($"Result of a + b * c = {c+d*e} - Multiplication before addition !");
            Console.WriteLine($"Result of (a + b)*c = {(c + d) * e} - Inside brackets first!");
            Console.WriteLine("");
            Console.WriteLine("Task 3: Explore integer precision and limits");
            int f = 7;
            int g = 4;
            int h = 3;
            Console.WriteLine($"Below is shown math operation for Integer a = {f}, b = {g} and c ={h}");
            Console.WriteLine($"(a+b)/c = {(f+g)/h}");
            Console.WriteLine($"(a+b)%c =  {(f+g)%h}");
            Console.WriteLine($"range of Integer is {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"an example of overflow  a + max = {int.MaxValue + f}");
            Console.WriteLine("");
            Console.WriteLine("Task 4: Double type");
            double i = 5;
            double j = 4;
            double k = 2;
            Console.WriteLine($"Below is shown math operation for Double a = {i}, b = {j} and c ={k}");
            Console.WriteLine($"Result of (a + b)*c = {(i + j) / k}");
            Console.WriteLine($"Range of Double is {double.MinValue} to {double.MaxValue}");
            Console.WriteLine("");
            Console.WriteLine("Task 5: Decimal type");
            decimal l = 1.0M;
            decimal m = 3.0M;
            double n = 1.0;
            double o = 3.0;
            Console.WriteLine($"Below is shown difference between decimal and double");
            Console.WriteLine($"Result of a/b = {n/o} - DOUBLE TYPE");
            Console.WriteLine($"Result of a/b = {l / m} - DECIMAL TPYE");
            Console.WriteLine($"Range of Double is {decimal.MinValue} to {decimal.MaxValue}");

            Console.WriteLine("");
            double radius = 2.5;
            Console.WriteLine($"Task 5: Area od Circle with radius {radius} is { Math.PI*Math.Pow(radius,2)} ");
        }

        static void Conditional_logic_Loops()
        {
            
            Console.WriteLine("CONDITIONAL AND LOOPS PREWORK");
            Console.WriteLine("");
            Console.WriteLine("Task 1 - Only IF operation");
            int a = 5;
            int b = 8;
            Console.WriteLine($"IF operations for a= {a} and b = {b}");
            if (a + b > 10)
                Console.WriteLine("a + b is greater than 10.");

            Console.WriteLine("");
            Console.WriteLine("Task 2 - IF and ELSE operation");
            int c = 5;
            int d = 3;
            Console.WriteLine($"IF and ELSE operations for a= {c} and b = {d}");
            if (c + d > 10)
                Console.WriteLine("a + b is greater than 10");
            else
                Console.WriteLine("a + b is not greater than 10");

            Console.WriteLine("");
            Console.WriteLine("Task 3 - WHILE Loop");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine("");
            Console.WriteLine("Task 4 - D0 - WHILE Loop");
            int counter_v1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter_v1}");
                counter_v1++;
            } while (counter_v1 < 10);
            Console.WriteLine("");
            Console.WriteLine("Task 5 - FOR Loop");
            for (int counter_v2 = 0; counter_v2 < 10; counter_v2++)
            {
                Console.WriteLine($"Hello World! The counter is {counter_v2}");
            }


        }
        static void List_Prework()
        {
            Console.WriteLine("LIST PREWORK");
            Console.WriteLine("");
            Console.WriteLine("Task 1 - Create Lists");
            var names = new List<string> { "Jakub", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("");
            Console.WriteLine("Task 2 - Modify Lists");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            Console.WriteLine("");
            Console.WriteLine("Task 3 - Search and Sort List");
            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            Console.WriteLine("Sorted list:");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

        }
        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose what Prework Lessons want you see:");
            Console.WriteLine("1. Hello World Prework");
            Console.WriteLine("2. Numbers Prework");
            Console.WriteLine("3. Conditional and Loops Prework");
            Console.WriteLine("4. List Prework");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            string userInput;

            do
            {
                Menu();
                userInput = Console.ReadLine();
                if (int.Parse(userInput) == 1)
                {
                    String_Prework();
                }
                if (int.Parse(userInput) == 2)
                {
                    Numbers_Prework();
                }
                if (int.Parse(userInput) == 3)
                {
                    Conditional_logic_Loops();
                }
                if (int.Parse(userInput) == 4)
                {
                    List_Prework();
                }

            } while (int.Parse(userInput) != 5);

            Console.WriteLine("GoodBye :)!");

        }
    }
}




