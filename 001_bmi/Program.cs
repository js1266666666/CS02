﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            Console.Write("키(cm): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("체중(kg): ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height / 100 * height / 100);
            //Console.Write("BMI= " + bmi);
            Console.WriteLine("BMI = {0}입니다.", bmi);
            //문자열 + 숫자 = 문자열
            //문자열 + 문자열 = 문자열

            //판정기준 추가(if~ else 사용)
            if (bmi < 20) {
                Console.WriteLine("저체중");
            }
            else if(bmi >= 20 && bmi < 25){
                Console.WriteLine("정상체중");
            }
            else if(bmi >=25 && bmi < 30)
            {
                Console.WriteLine("경도비만");
            }
            else if(bmi>=30 && bmi < 45)
            {
                Console.WriteLine("비만");
            }
            else if(bmi >= 40)
            {
                Console.WriteLine("고도비만");
            }
      }
    }
}