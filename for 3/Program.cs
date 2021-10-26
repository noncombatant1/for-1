using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Среди натуральных чисел от 1 до N(включая N), найдите число, наибольшее по сумме цифр. Вывести это число и сумму его цифр
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int i ;
            for (i = 1; i <= n; i++)
            {
                int sum = 0;
                while (i != 0)
                {
                    int m = i % 10;
                    sum += m;
                    i /= 10;
                }
                 max = sum;
            }
            Console.WriteLine(n + " " + max);
            Console.ReadKey();
        }
    }
}
