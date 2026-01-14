using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ////Dictionary키 key값과 value로 구성 쌍으로 데이터 저장
            //Dictionary<string, int> stats = new Dictionary<string, int>();
            //stats.Add("HP", 150);
            //stats.Add("MP", 100);
            //stats.Add("공격력", 50);
            //stats.Add("방어력", 30);

            //인덱스가 정수로 잡혀있지않음 출력은? 

            //Console.WriteLine(stats["HP"]);

            //출력할땐 얘가 편하다! 
            //Console.WriteLine("===캐릭터 스탯===");
            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}
            ////키의 존재 확인 
            //string searchStat = "방어력";
            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine($"{searchStat} :{stats[searchStat]}");

            //}
            //else
            //{
            //    Console.WriteLine("해당 스탯이 없습니다");
            //}

            Console.WriteLine("===상점 아이템===");
            Dictionary<string, int> cellItem = new Dictionary<string, int>();
            cellItem.Add("회복 포션", 50);
            cellItem.Add("마나 포션", 40);
            cellItem.Add("강철 검", 500);
            cellItem.Add("가죽 갑옷", 300);
            cellItem.Add("마법 반지", 1000);

            foreach (KeyValuePair<string, int> select in cellItem)
            {
                Console.WriteLine($"{select.Key}: {select.Value}");
            }
            string keySword = "강철 검";
            if (cellItem.ContainsKey(keySword)) { 
            Console.WriteLine($"✅ {keySword}을 {cellItem["강철 검"]}G에  구매하셨습니다");
            }
            else
            {
                Console.WriteLine("구매 실패");
            }
        }
    }
}
