using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Player
    {
        private string name;
        private int gold;
        private int maxHP;

        //프로퍼티 MaxHP (읽기전용)
        public int MaxHP
        {
            get { return maxHP; } 
            private set { maxHP = value; }
        }
        public string Name { get { return name; } set { name = value; } }
        public int Gold 
        {
            get { return gold; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("골드가 부족함");
                }else
                {
                    gold = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Name = "덕배";
            p.Gold = -5;

            Console.WriteLine("이름 :"+p.Name +"\n보유골드 :"+p.Gold+" G");
        }
    }
}
