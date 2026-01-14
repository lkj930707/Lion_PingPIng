using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터 선택화면을 switch로 만드시오
            //jobChoice = 1 전사 2 마법사 3궁수 4도적
            Console.WriteLine("직업을 선택하시오 1.전사2.마법사3.궁수4.도적");
            int job = int.Parse(Console.ReadLine());
            string jobSelect= "";
            string weapon = "";
            string state = "";

            switch (job)
            {
                case 1: jobSelect = "전사";
                    weapon = "검";
                    state = "힘";
                    break;
                case 2:
                    jobSelect = "마법사";
                    weapon = "지팡이";
                    state = "지";
                    break;
                case 3:
                    jobSelect = "궁수";
                    weapon = "활";
                    state = "민";
                    break;
                case 4:
                    jobSelect = "도적";
                    weapon = "단검";
                    state = "운";
                    break;
                default:Console.WriteLine("1~4의 숫자중선택해주세요");
                    break;
            }

            Console.WriteLine("===캐릭터 생성===");
            Console.WriteLine($"직업: {jobSelect}");
            Console.WriteLine($"주무기: {weapon}");
            Console.WriteLine($"스탯: {state} :5 ");
        }
    }
}
