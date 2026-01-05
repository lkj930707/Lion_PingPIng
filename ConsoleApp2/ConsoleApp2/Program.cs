using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////리터럴 : 코드에서 고정된값
            //int num = 10;  //정수 리터럴
            //double pi = 3.14;//실수 리터럴
            //char letter = 'A';//문자 리터럴
            //string name = "Mr.Lee";//문자열 리터럴

            //Console.Write(num+"\n"+pi+"\n"+letter+"\n"+name); //출력 write는 줄띄움이없음
            //                                                  //writeLine은 마지막에 줄띄움포함


            //리터럴 연습
            //플레이스코어 100
            //파이 3.14
            //등급'A'가 
            //플레이어이름

            int playScore = 100;
            double pi = 3.14;
            char rating = 'A';
            string name = "Mr.Lee";
            bool isGameOver = false; // 논리 

            Console.Write(playScore + "\n" + pi + "\n" + rating + "\n" + name + "\n"+isGameOver);
        }
    }
}
