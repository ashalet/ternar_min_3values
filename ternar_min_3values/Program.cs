using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternar_min_3values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min_value;
            Console.WriteLine("Введите три числа: ");



            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());



            min_value = x < y ? x < z ? x : z : y < z ? y : z;


            Console.WriteLine($"Минимальное число: {min_value}");
            Console.ReadLine();
        }
        
    }
}
