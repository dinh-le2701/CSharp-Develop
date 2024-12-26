/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class List
    {
        static void Main(string[] args)
        {
            // List - Declare a List
            // List<type> variableName = new List<type>();
            List<int> numbers = new List<int>();

            Console.WriteLine("Nhap chieu dai mang: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu: ");
                int a = int.Parse(Console.ReadLine());
                numbers.Add(a);
            }

            Console.Write("Mang []: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Phan tu thu {numbers[3]}: " + numbers[3]);
            Console.WriteLine();
            Console.WriteLine("Xoa phan tu thu 3: ");
            numbers.Remove(numbers[2]);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
*/