using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터 상태 판정 
            Console.WriteLine("===캐릭터 상태===");
            Console.WriteLine("체력을 입력하세요");
            
            int health;
            health = int.Parse(Console.ReadLine());
            if (health >= 80) Console.WriteLine("HP상태 : 매우 좋음");
            if (health >= 60) Console.WriteLine("HP상태 : 좋음");
            if (health >= 40) Console.WriteLine("HP상태 : 위험");
            if (health >= 20) Console.WriteLine("HP상태 : 매우위험");
            else Console.WriteLine("HP상태 : 딸피");
        }
    }
}
