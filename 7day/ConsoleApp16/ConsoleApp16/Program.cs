using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
   
    internal class Program
    {
        static void PrimeNum(int a)
        {
            if (a==2||a==3||a==5||a==7)
            {
                Console.WriteLine(a+"나는 소수다");
            }
            else if (a % 2 !=0 && a%3 !=0 && a % 5 !=0)
            {
                Console.WriteLine(a + "나는 소수다");
            }else
            {
                Console.WriteLine(a+"너는 소수가 아니다");
            }
        }
        static void Main(string[] args)
        {//문제 3 숫자를 받아 소수인지 판별 
            Console.WriteLine("소수판별 :");
            string num = Console.ReadLine();
            PrimeNum(int.Parse(num));

        }
    }
}
