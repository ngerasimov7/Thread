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
                Name = "Поток расчета факторила";
            }
            Fthread.Name=""
            //Factorial.Text = fact(int.Parse(N.Text)).ToString();
            //Summa.Text = summ(int.Parse(N.Text)).ToString();


        }

        static void fact()
        {
            Console.WriteLine($"Факториал числа {N} = {ffact(N)}");
        }

        static  BigInteger ffact(BigInteger num)
        {
            return (num == 0) ? 1 : num * ffact(num - 1);
        }

        static int summ(int num)
        {
            return (num == 0) ? 0 : num + summ(num - 1);
        }
    }
}
