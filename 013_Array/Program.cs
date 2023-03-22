using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10개짜리 정수 배열을 만들자
            int[] a = new int[10];

            //10개의 숫자 입력 받아 배열에 저장
            for (int i = 0; i <= 2; i++)
                a[i] = int.Parse(Console.ReadLine());

            //배열에 저장된 10개의 숫자 출력

            for (int i = 0; i < 10; i++)
                Console.Write(a[i]+ " ");
            Console.WriteLine();

            foreach (var x in a)
                Console.Write(x + " ");
            Console.WriteLine();

            //문자열을 5개 저장할 수 있는 배열을 만들고 입력 받은 후 출력
            string[] b = new string[5];

            for (int i = 0; i <= 4; i++)
                b[i] = Console.ReadLine();

            foreach (var s in b)
                Console.Write(s + " ");
        }
    }
}
