using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("글씨를 입력하세요");
            string userInput = Console.ReadLine(); //사용자입력을 문자열로 받기

            Console.WriteLine($"안녕하세요 ,{userInput} 님 환영합니다");
        }
    }
}
