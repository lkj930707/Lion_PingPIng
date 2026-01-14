using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string uinput = Console.ReadLine();

            //int age = int.Parse(uinput);
            //Console.WriteLine($"니 나이는 내년에{age+1} 입니다 ");

            ////2진수 정수 변환 
            //Console.WriteLine("2진수 입력하세요");
            //string binaryinput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryinput,2); // 2진수 > 10진수 

            ////정수의 2진수변환
            //String binaryOutput = Convert.ToString(decimalValue, 2); //10진수 > 2진수 

            //Console.WriteLine($"입력한 2진수 {binaryinput} 은 10진수로 {decimalValue} 입니다 ");

            //문제
            Console.WriteLine("===캐릭터 생성===");
            Console.Write("캐릭터 이름을 입력하세요:");
            string name = Console.ReadLine();
            Console.WriteLine("환영합니다" +name +"님");
            Console.WriteLine("시작 레벨을 입력하세요:");
            string level = Console.ReadLine();
            int levels = int.Parse(level);
            Console.WriteLine(name + "님의 시작레벨은 " + levels + "입니다");

            

        }
    }
}
