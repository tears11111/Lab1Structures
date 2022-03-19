using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            long a, b;
            int x = 0, y = 1;
            long max = 0, divider = 0;
            bool isEqual = false;
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());

            if (a > b && b > a / 2) max = a / 2;
            else if (a > b && b < a / 2) max = b;
            else if (a < b && a > b / 2) max = b / 2;
            else max = a;

            for (long i = max; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    divider = i;
                    break;
                }
                    
            }

            while (isEqual != true)
            {
                x--;
                for (int i = y; a * x + b * i <= divider; i++)
                {
                    if (a * x + b * i == divider)
                    {
                        y = i;
                        isEqual = true;
                        break;
                    }
                }
                
            }
            Console.WriteLine(@"{0} {1} {2}", divider, x, y);
            Console.WriteLine("Работу выполнил: Блохин Валентин Владимирович\nГруппа: РПИа-021");
            Console.ReadKey();
        }
    }
}
