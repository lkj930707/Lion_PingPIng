using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자의 우선순위 
            //괄호를 이용하여 우선순위를 지정한다 
            //int a = 1 ,b =2 ,c = 3;
            //Console.WriteLine(a + b * c); //1. 곱셈이 덧셈보다 우선
            //Console.WriteLine(a * (b + c)); //괄호로 우선순위를 지정할수있다
            //Console.WriteLine((a - b) * c); 

            // 예제 2: 데미지 계산
            int  baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0


        }
    }
}
