using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Character
    {
        public static int totalCount = 0; //스태틱변수 : 모든 캐릭터가 공유가능한 
        public string name; //각 캐릭 마다다름

        public void AddCount()
        {
            totalCount++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            Character c2 = new Character();
            c.name = "전붕이";
            c2.name = "법사";

            Character.totalCount = 1; // 전붕이나 법사나 토탈카운트에 1대입


            c.AddCount();
            c2.AddCount();
            Console.WriteLine(c.name+" "+c2.name);
            Console.WriteLine("카운트 :"+Character.totalCount);
        }
    }
}
