using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제
            //**실행결과**
            //현재 체력: 30/100
            /*⚠️ 경고: 체력이 위험합니다!
              회복 아이템을 사용하세요!
             💊 체력이 50 % 이하입니다.

             ⚔️ 적이 사거리 안에 있습니다!
             공격 가능!*/

            int cHp = 30;
            int mHp = 100;
            bool isEnemies = true;
            int myRange = 3;
            int enemyRange = 2;
            bool isRange;


            if (myRange > enemyRange) isEnemies = true;

            Console.WriteLine("**실행결과**");
            Console.WriteLine($"현재 체력: {cHp} / {mHp}");
            if(cHp < 50) {
                Console.WriteLine("체력이 위험합니다");
                Console.WriteLine("회복 아이템을 사용하세요!");
                Console.WriteLine("체력이 50% 이하입니다");
            }else if(cHp == 0)
            {
                Console.WriteLine("캐릭터가 사망 했습니다");
            }
            if (isEnemies)
            {
                Console.WriteLine("적이 사거리안에있습니다");
                Console.WriteLine("공격 가능!");
            }
            else
            {
                Console.WriteLine("적이 사거리밖입니다");
                Console.WriteLine("공격이 불가합니다");
            }
            
            
            
        }
    }
}
