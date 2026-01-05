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
            ////형식이 같은 변수
            //int a = 10, b = 11, c = 12; //한 번에 선언 및 초기화
            //string name = "쩝쩝이", nick = "핑핑이", job = "암살자";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //Console.Write("나이: {0} \n", a);
            //Console.Write("나이: {0} \n이름:{1}\n", a,name);

            //Console.WriteLine($"명칭: {nick}");

            //3d 좌표 예시 
            int posX = 0, posY = 50, posZ = 100;

            //RGB 색값 예시 
            int red = 255, green = 128, blue = 0;

            Console.WriteLine("X좌표:" + posX + " Y좌표:" + posY + " Z좌표:" + posZ);
            Console.WriteLine("X좌표:{0} Y좌표:{1} Z좌표:{2}",posX,posY,posZ);
            Console.WriteLine($"X좌표:{posX} Y좌표:{posY} Z좌표:{posZ}");

            Console.WriteLine("R:" + red + " G:" + green + " B:" + blue );
            Console.WriteLine("R:{0} G:{1} B:{2}",red,green,blue);
            Console.WriteLine($"R:{red} G:{green} B:{blue}");

        }
    }
}
