using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Варіант 22
            Задача: 
            Із заданою точністю обчислити значення константи е
             */


            Console.WriteLine("Enter accurasy:  ");
            try
            {
                double accurasy = Convert.ToDouble(Console.ReadLine()); // точність

                double constE = 0; // константа е
                int i = 1; // при обчислені факторіала це число відповідно якого шукається факторіал (наприклад 3! - 3 це "і")
                double previousE = 1; // попереднє значення е
                int fact = 1; // обчислений факторіал

                while (Math.Abs(constE - previousE) > accurasy)
                {
                    for (int j = 1; j < i; j++)
                    {
                        fact = fact * j; // обчислюємо факторіал
                    }

                    previousE = constE; //перед зміненням Е, його попереднє значення записуємо у previousE

                    constE = constE + (double)1 / fact;
                    Console.WriteLine($"E  =  {constE}");
                    fact = 1;
                    i++;
                }

                Console.Write($"\n\nОстаточне E  =  {constE}\n\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
