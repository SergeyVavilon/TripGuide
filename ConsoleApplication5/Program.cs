using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите число столбцов");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число строк");
            b = int.Parse(Console.ReadLine());

            int[,] array = new int[a, b];

            Random rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
