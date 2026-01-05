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
            ////상수 : 값을 변경 할 수 없는 변수 고정!
            //const double pi = 3.14159;   // 실수의 상수선언 
            //const int MaxScore = 100; // 정수의 상수선언



            //Console.WriteLine("Pi: " + pi+"\nMax Score: "+MaxScore);

            const int player = 4;
            int gold = 1000;
            string version = "1.0.0";

            Console.WriteLine("게임설정 ");
            Console.WriteLine("최대 플레이어 수: " + player);
            Console.WriteLine("초기 골드: " + gold);
            Console.WriteLine("게임버전: " + version);




        }
    }
}
