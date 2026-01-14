using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ////가변 배열
            //string[][] raid = new string[3][];
            //raid[0] = new string[4] { "전붕", "쌀레", "썬콜", "궁붕" };
            //raid[1] = new string[5] { "hp", "mp", "str", "dex", "int" };
            //raid[2] = new string[6] { "1", "2", "3", "4", "5", "6" };

            //for (int i = 0; i < raid.Length; i++)
            //{
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.Write($"{raid[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //동적배열 List<T>꼴 크기가 자동으로 조절되는 동적 배열 
            //System.Collections.Generic 네임스페이스에 포함

            //선언방법
            //List<int> num = new List<int>();
            //List<string> str = new List<string>();
            //List<float> fnum = new List<float>();

            ////초깃값과 선언
            //List<int> scores = new List<int> { 80,90,100};
            //List<string> items = new List<string> {"검","포션","주문서" };

            ////추가 방법 Add: 끝에 추가 
            //items.Add("집행검 +6");
            //foreach (string i in items)
            //{
            //    Console.WriteLine(i);
            //}



            //리스트 사용법
            List<string> inven = new List<string>();
            Console.WriteLine("===도적 인벤토리 시스템===");

            //아이템 추가 Add함수 
            inven.Add("토끼공듀의 지갑");
            inven.Add("타락파워전사의 노잣돈");
            inven.Add("거지의 옷자락");

            //현재 인벤토리 
            Console.WriteLine($"인벤토리 ({inven.Count})");
            foreach (string s in inven)
            {
                Console.WriteLine($"[{s}]");
            }
            inven[0] = "초록포션";
            foreach (string s in inven)
            {
                Console.WriteLine($"[{s}]");
            }

            //특정 위치에 추가(Insert)
            Console.WriteLine("전설의 검을 줏었다.");
            inven.Insert(1, "전설의 검"); // 껴넣은 것이므로 늘어난것 
            foreach (string s in inven)
            {
                Console.WriteLine($"[{s}]");
            }

            //아이템 제거 (Remove)  //다지우고싶다 RemoveAll ,지정인덱스만삭제 = Remove ,RemoveAt(0)지정 인덱스삭제 
            inven.Remove("전설의 검");
            Console.WriteLine("'전설의 검'을 버림");
            foreach(string s in inven)
            {
                Console.WriteLine($"[{s}]");
            }


        }
    }
}
