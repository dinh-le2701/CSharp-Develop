/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class String
    {
        static void Main(string[] args)
        {
            var hello = "Hello";
            Console.WriteLine(hello); // result: Hello

            var letter = hello[1];
            Console.WriteLine(letter); // result: e

            var length = hello.Length;
            Console.WriteLine(length);  // result: 5


            // Combine two strings together using: + & string.Concat method
            var firstName = "Dinh";
            Console.WriteLine(firstName);

            var lastName = "Le Tat";
            Console.WriteLine(lastName);

            string fullname = firstName + lastName;
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(string.Concat("Hello ", firstName, " ", lastName));

            Console.WriteLine();

            // String Interpolation $ - {}
            var number = 10;
            Console.WriteLine($"This is a number: {number}");

            Console.WriteLine();

            // String methods
            var stringChar = "hi, my name is dinh";
            Console.WriteLine("ToLower: " + stringChar.ToLower());
            Console.WriteLine("ToUpper: " + stringChar.ToUpper());
            Console.WriteLine("Trim: " + stringChar.Trim());
            Console.WriteLine("TrimStart: " + stringChar.TrimStart());
            Console.WriteLine("TrimEnd: " + stringChar.TrimEnd());
            Console.WriteLine("Index Of: " + stringChar.IndexOf("dinh"));
            Console.WriteLine("Last Index Of: " + stringChar.LastIndexOf("nh"));
            Console.WriteLine("SubString: " + stringChar.Substring(7, 11));
            Console.WriteLine("Replace: " + stringChar.Replace("hi", "Hello"));
        }
    }
}
*/