using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;

namespace ConsoleThread
{
    class Program
    {
        static BigInteger N;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для которого необходимо произвести расчет факториала и суммы целых чисел");
            N = int.Parse(Console.ReadLine());

            Thread Fthread = new Thread(new ThreadStart(fact))
            {
                Name = "Поток расчета факторила",
                Priority = ThreadPriority.Lowest
            };
            Fthread.Start();

            Thread Sthread = new Thread(new ParameterizedThreadStart(summ))
            {
                Name = "Поток расчета суммы чисел",
                Priority = ThreadPriority.Highest
            };
            Sthread.Start(N);

            Console.ReadKey();
        }

        static void fact()
        {
            Console.WriteLine($"Факториал числа {N} = {ffact(N)}");
        }

        static void summ(object n)
        {
            Console.WriteLine($"Сумма чисел {(BigInteger) n} = {fsumm((BigInteger) n)}");
        }

        static  BigInteger ffact(BigInteger num)
        {
            return (num == 0) ? 1 : num * ffact(num - 1);
        }

        static BigInteger fsumm(BigInteger num)
        {
            return (num == 0) ? 0 : num + fsumm(num - 1);
        }
    }
}
