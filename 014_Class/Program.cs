using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            //랜덤 숫자 5개 출력
            for (int i = 0; i <= 4; i++)
                Console.WriteLine(r.Next(100));

            // 숫자 20개를 랜덤하게 만들어 배열에 저장한다
            int[] a = new int[20];
            for (int i = 0; i <= 19; i++)
            {
                a[i] = r.Next(100);
                Console.Write(a[i] + " ");
            }

            int max = a[0];
            int min = a[0];
            int sum = 0;

            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                if (max < a[i])
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("Max =" + max);
            Console.WriteLine("Min =" + min);

            for (int i = 0; i <= 19; i ++)
                sum += a[i];

            double avg = sum / 20.0;
            Console.WriteLine("Avg = " + avg);
        }
    }
}
