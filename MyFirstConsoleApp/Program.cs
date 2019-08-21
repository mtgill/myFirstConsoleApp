using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVariable = "Hello World";

            int myIntVariable;
            myIntVariable = 1234;

            decimal myDecimalVariable;
            myDecimalVariable = 123.456m;

            DateTime myDateTime = new DateTime();

            bool myBool = false;

            if (myBool)
            {
                Console.WriteLine("Unreachable code");
            }

            switch (myIntVariable)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 1234:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"we're on interation {i}");
            }


            List<string> myStrings = new List<string>();
            myStrings.Add("words");
            myStrings.Add("words1");
            myStrings.Add("words2");
            myStrings.Add("words3");
            //myStrings.Insert(1, "blerg");
            //myStrings.Remove("Blerg);
            //myStrings.RemoveAt(1);

            foreach(var myString in myStrings)
            {
                Console.WriteLine(myString);
            }
        }
    }
}
