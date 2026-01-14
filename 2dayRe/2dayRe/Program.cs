using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _2dayRe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 5.5f; //정밀도낮음 float 형은 뒤에 f 작성 
            double b = 5.5; // double형은 정밀도 높음
            decimal c = 5.55m; // decimal 형은 뒤에 m 작성 초고정밀도
            long d = 50000L; // long 형은 뒤에 L 작성 

            bool isTrue = true; // bool 형은 뒤에 false 또는 true 가능 

            const int AA = 10; // const 는 상수 ! 값 변경 불가 + 관례적으로 대문자를 사용
            char bb = 'A'; // char 형은 홑따옴표 사용 내부값을 정수로변환해 찍으면 아스키코드값 출력됌
            //형변환 
            int num = 5; // 
            string thisNum = num.ToString();  // int 형을 string 형으로 변환
            Console.WriteLine(thisNum); 

            string str = "1234";
            int thisStr = int.Parse(str); // string 형을 int 형으로 변환
            Console.WriteLine(thisStr);


            int hp = 50;
            bool isDie = hp == 0;
            bool isAlive = !isDie;
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"사망여부 {isDie}");
            Console.WriteLine($"생존여부 {isAlive}");

            Thread.Sleep(1000); // 1초 대기 
            //+오늘은 깃설치 및 깃 코밋 해봤다

        }
    }
}
