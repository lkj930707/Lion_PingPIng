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
            //문제 헬쓰: 30
            //맥스헬쓰: 100
            //헬스상태 70 =안전 70~30 주의 그이하 위험

            int health = 30;
            int maxHealth = 100;
            string state = (health > 70) ? "안전" 
                : (health >= 30) ? "주의" : "위험";
            
            Console.WriteLine("체력    :"+health);
            Console.WriteLine("최대체력:"+maxHealth);
            Console.WriteLine("현재상태:"+state);
        }
    }
}
