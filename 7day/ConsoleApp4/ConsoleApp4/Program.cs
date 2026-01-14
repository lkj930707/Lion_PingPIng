using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        //반환값이 있는 함수 3단계 
        static int GetNum()
        {

            return 52;
        }
        //문자열 반환 2단계/반환
        static string ConnectMessage(string name)
        {
            return name+"님 접속하셨습니다";
        }
        string GetName()
        {
            return "김덕배";
        } 
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num = GetNum();
            Console.WriteLine("메소드에서 숫자반환:"+num);
            Console.WriteLine("닉네임을 입력하세요:");
            string cm = Console.ReadLine();
            Console.WriteLine(ConnectMessage(cm));

        }
    }
}
