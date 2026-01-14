using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지: 50");
        }
        static void Attack(int a)
        {
            //메서드 오버로딩
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지:"+a);
        }
        static int Attack(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Attack(string tar,int dam)
        {
            Console.WriteLine($"{tar}기본공격");
            Console.WriteLine($"데미지 : {dam}");
        }
        static void Attack(string skill1,string tar,int damage)
        {
            Console.WriteLine($"{skill1}스킬사용");
            Console.WriteLine($"{tar}은");
            Console.WriteLine($"데미지{ damage}를 입었다");
        }
        static void Main(string[] args)
        {
            //메서드의 오버로딩 
            //Attack();
            //Attack(1);
            //Attack(2,3);
            //Attack("덕배",4);
            Attack("파이어볼", "고블린", 15);
        }
    }
}
