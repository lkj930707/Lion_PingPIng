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
            Console.OutputEncoding = Encoding.UTF8;

           // MeleeDamage(100,20);
            Status("덕배", 30, 50, 15, 6);

        }
        //매개변수가 있는 함수 
        static void MeleeDamage(int dmg,int def)//두개받고반환
        {
            Console.WriteLine("공격력을 전달받음:" + dmg);
            Console.WriteLine("방어력을 전달받음:" + def);
        }
        //함수로만들기
        static void Status(string name,int dmg,int def,int dex,int luk)
        {
            Console.WriteLine("플레이어 이름 :"+name);
            Console.WriteLine("공격력        :"+dmg);
            Console.WriteLine("방어력        :"+def);
            Console.WriteLine("민첩          :"+dex);
            Console.WriteLine("운            :"+luk);
        }
        //3단계 반환값이 있는 함수 

    }
}
