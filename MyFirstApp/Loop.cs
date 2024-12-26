using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            var a = int.Parse(Console.ReadLine());

            // while loop
            while (a < 25)
            {
                ++a;
                Console.WriteLine(a);
            }

            Console.WriteLine();

            // do..while loop
            Console.Write("Nhap b: ");
            var b = int.Parse(Console.ReadLine());
            do
            {
                b++;
                Console.WriteLine(b);
            } while (b <= 25);

            Console.WriteLine();


            // for loop



            /// foreach loop
        }
    }
}
