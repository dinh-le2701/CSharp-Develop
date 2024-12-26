/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Conditions
    {
        static void Main(string[] args)
        {
            // If Else - If Else If
            Console.Write("Nhap a: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            var b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a == b");
            }
            else if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a = b");
            }


            // Ternary Operator: shorrthand if...else
            // variable = (condition) ? valueTrue : valueFalse
            var time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(time);

            if (time < 10)
            {
                Console.WriteLine("Good morning!");
            }
            else
            {
                Console.WriteLine("Good day!");
            }

            Console.WriteLine("Nhap so tuoi cua ban: ");
            int age = int.Parse(Console.ReadLine());
            var message = (age < 18) ? "Ban qua' tre?" : "Ban da gia` roi`!";
            Console.WriteLine(message);


            // Switch statement
            Console.WriteLine("Nhap tháng: ");
            var month = int.Parse(Console.ReadLine());
            switch (month)
            {
                default:
                    break;
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3: 
                    Console.WriteLine("March");
                    break;
                case 4: 
                    Console.WriteLine("April");
                    break;
                case 5: 
                    Console.WriteLine("May");
                    break;
                case 6: 
                    Console.WriteLine("June");
                    break;
                case 7: 
                    Console.WriteLine("July");
                    break;
                case 8: 
                    Console.WriteLine("August");
                    break;
                case 9: 
                    Console.WriteLine("September");
                    break;
                case 10: 
                    Console.WriteLine("October");
                    break;
                case 11: 
                    Console.WriteLine("November");
                    break;
                case 12: 
                    Console.WriteLine("December");
                    break;

            }

        }
    }
}
*/