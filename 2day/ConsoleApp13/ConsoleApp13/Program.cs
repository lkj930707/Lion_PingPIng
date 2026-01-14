using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string 형식: 여러 문자를 저장
            //string greeting = "hello world!"; //문자열 저장 
            //string name = "James"; //이름저장 

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';

            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다";
            //string emptyString = "";

            //Console.WriteLine("**실행결과: **");
            //Console.WriteLine("플레이어: " + playerName);
            //Console.WriteLine("등급 :"+grade + "등급 " + symbol);
            //Console.WriteLine(welcomeMessage);
            int num = 9; // 숫자
            char charnum = '9'; // 문자

            Console.WriteLine("=== 숫자 vs 문자 === ");
            Console.WriteLine($"숫자 9 : {num}");
            Console.WriteLine($"문자 9 : {charnum}");

            int a;
            a = charnum;
            Console.WriteLine($"문자 9를 int형 변수에 대입: {a}"); //아스키코드값이 출력

        }
    }
}
