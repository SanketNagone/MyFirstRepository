using System;
using System.Collections.Generic;

namespace MyFirstApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World Dev");
            Console.WriteLine("Dev 1 Commit");
            Console.WriteLine("Dev 2 Commit");
            Console.WriteLine("Changes");


            Console.WriteLine("New Feature Changes");
            Console.WriteLine("New Feature Changes 2");
            Console.WriteLine("New Feature Changes 3");
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }


    public class TestSonar
    {
        int hascode = 0;
        public List<String> names { get; set; }

        public override int GetHashCode()
        {
            foreach (string name in names)
            {
                hascode += name.GetHashCode();
            }

            return hascode;
        }

    }
}