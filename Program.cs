using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитаем длину окружности\nBведите радиус:");
            string r = Console.ReadLine();
            double x = Convert.ToDouble(r);
            float Pi = 3.141592f;
            Double d = Pi * x;
            Console.WriteLine("Длина окружности:");
            Console.WriteLine(d);

            string result = d > 30 ? "Длина окружности больеш 30" : "Длина окружности меньше 30";
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
