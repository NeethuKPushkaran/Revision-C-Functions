
using System;
using System.ComponentModel;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function with no Parameter and no return type
            SayHello();

            //Function with Parameter but no return type
            GreetUser("Alice");

            //Function with Parameter and return type
            int product = Product(5, 3);
            Console.WriteLine(product);

            //Function with no parameter but return type
            int temperature = GetTemperature();
            Console.WriteLine(temperature);

            //Function overloading
            Console.WriteLine(Add(6,4));
            Console.WriteLine(Add(2.50,3.40));

            //Optional Parameters

            DisplayMessage("Hello, World!");
            DisplayMessage("Hello, Alice!", 3);

            //Named Parameters

            DisplayMessage("Hello, Jim", times: 2);

        }

        //Function with no Parameter and no return type
        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        //Function with Parameter but no return type
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello { name }");
        }

        //Function with Parameter and return type
        static int Product(int x, int y)
        {
            return x * y;
        }

        //Function with no parameter but return type
        static int GetTemperature()
        {
            return 37;
        }

        //Function overloading
        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        //Optional Parameters
        static void DisplayMessage(string message, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}