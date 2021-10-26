using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитать, сколько раз встречается цифра 7 в последовательности чисел от 1 до N, включая N.
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int j = i;
                while (j != 0)
                {
                    
                    j %= 10;
                    if (j == 7)
                    {
                        sum++;
                    }
                    j /= 10;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
