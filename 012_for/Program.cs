using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _012_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 1~100까지 더하기
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            //2. 1~100 홀수의 합

            int sum2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    sum2 += i;
                }
            }
            //3. 1~100까지 역수의 합
            double sum3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum3 += 1.0 / i;
            }
            Console.WriteLine("1~100까지 더한 값 : {0}",sum);
            Console.WriteLine("1~100 홀수의 합 : {0}", sum2);
            Console.WriteLine("1~100까지 역수의 합 : {0}", sum3);

            //구구단
            Console.Write("구구단의 단을 입력 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
