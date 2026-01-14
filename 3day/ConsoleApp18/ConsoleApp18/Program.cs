using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var 키워드 암시적으로 컴파일러가 형식을 추론함 
            //var num = 10; // 정수로 추론하되 반드시 초기화 필요
            //var name = "김덕배"; //문자열 추론
            //var isMan = true; //논리 추론
            //Console.WriteLine(num + "\n"+name+"\n"+isMan);

            //var re = (num > 5) ? "크다" : "작다";
            //            Console.WriteLine(re);

            //default 키워드를 사용한 기본값 설정 
            int defaultInt = default; // 0
            string defaultString = default; // null
            bool defaultBool = default; // false
            Console.WriteLine("int  형식의 기본값은 : " + defaultInt);
            Console.WriteLine("string 형식의 기본값 : " + defaultString);
            Console.WriteLine("bool 형식의 기본값 : " + defaultBool);



        }
    }
}
