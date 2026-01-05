using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool 타입 : 논리 데이터 타입 참 or 거짓 
            bool isRunning = true; //1
            bool isDead = false; //0

            Console.WriteLine(isRunning); // True
            Console.WriteLine(isDead);    // False

            //for(int a=1; a < 9; a++)
            //{
            //    isRunning = !isRunning; 
            //}
            //Console.WriteLine(isRunning);

            //예제 

            //bool isState = false;
            //bool isPaused = true;
            //bool hasKey = true;
            //bool doorOpen = false;
            //bool isPlayerAlive = false;
            //int hp = 80;
            //bool ishealthy = hp >= 50;
            //bool isInDanger = hp <50; 



            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {!isState}");
            //Console.WriteLine($"일시정지: {isPaused}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {doorOpen}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");
            //Console.WriteLine("\n");
            //Console.WriteLine("===캐릭터 상태 ===");
            //Console.WriteLine($"체력: {hp} ");
            //Console.WriteLine($"건강 상태: {ishealthy} ");
            //Console.WriteLine($"위험 상태: {isInDanger}");


            // System.Int32 dummyNum = 222222; //상단에 using System; 이 있기 때문에 System 생략 가능
            //Console.WriteLine(dummyNum);

            int num = 123;
            string numStr = num.ToString(); //int -> string 변환 형변환

            bool flag = true;
            string flagStr = flag.ToString(); //bool -> string 형변환
            Console.WriteLine(numStr);  // "123"문자열을 찍는느낌
            Console.WriteLine(flagStr); // "true" 문자열을 찍는느낌

            int flagInt = int.Parse(numStr);
            Console.WriteLine(flagInt); //완





        }
    }
}
