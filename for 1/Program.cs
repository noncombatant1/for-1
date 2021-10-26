using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // На отрезке натуральных чисел от a до b, найдите числа, количество делителей которых не меньше k
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int sum = 0;
                for (int n = 1; n <= b; n++)
                {
                    if (i >= 10)
                    {
                        i %= 10;
                        sum += i;
                        i /= 10;
                    }
                }
                if (sum >= k)
                    Console.Write(i + " " + sum);
            }
            Console.ReadKey();
        }
    }
}
