using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("현재 온도를 입력해보세요:");
            string str = Console.ReadLine();
            int temp= int.Parse(str);

            if(temp >= 30)
            {
                Console.WriteLine("매우 더우니 반팔과 반바지를 입으세요");
            }else if (temp>= 20 && temp < 30)
            {
                Console.WriteLine("적당해요 긴팔 티셔츠를 입으세요");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("쌀쌀해요 가디건을 입으세요");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("매우추워요 코트를 입으세요");
            }else
            {
                Console.WriteLine("나가면 죽어요");
            }


        }
    }
}
