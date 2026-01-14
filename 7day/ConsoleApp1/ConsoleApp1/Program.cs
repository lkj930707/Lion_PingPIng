using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //함수 
            //메모리 영역 
            ShowGameStart();
            PrintSeparator();
            Console.WriteLine("게임 메뉴 불러오는 중...");
            PrintSeparator();
            Console.WriteLine("게임 종료");
            PrintSeparator();
            //BetaBlue();//재사용 성이 뛰어남
            //BetaBlue();//재사용 성이 뛰어남
            //Console.WriteLine(BetaRed(3, 6));
            //Console.WriteLine(BetaRed(2, 6));
        }
        static void BetaBlue(){
            int a = 10, b = 20;
            int sum = a + b;
            Console.WriteLine(sum);

        }//아무것도없는 기본함수 반환값이 보이드
        //함수 전체실행 

        static int BetaRed(int x, int y)//더하기
        {
            int sum = x + y;
            return sum;
        }
        //함수 정의: 게임 시작 메시지
        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ ⚔ RPG 게임 시작 ⚔                 ║");            
            Console.WriteLine("╚═══════════════════════════════════╝");
           
        }
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }
    }
}
