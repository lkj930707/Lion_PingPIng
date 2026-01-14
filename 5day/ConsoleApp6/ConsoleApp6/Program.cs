using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int TARGETX = 50;
            const int TARGETY = 20;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            int x=10 , y = 10;
            
            ConsoleKeyInfo keyInfo; //키관련 정보 

            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y); //커서좌표
                Console.Write("○");//현재 위치 출력

                Console.SetCursorPosition(TARGETX, TARGETY);
                Console.Write("🏠");

                if (x == TARGETX && y == TARGETY)
                {
                    Console.Clear();
                    Console.WriteLine("집도착 ");
                    break;
                }


                keyInfo = Console.ReadKey(); //키입력 받기 (화면출력 x)
                //방향키 입력에 따른 좌표 변경
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight-1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth-1) x++; break;
                    case ConsoleKey.Spacebar: 
                        Console.Write("■■■■■■■■■■■■■■■▶");
                        Thread.Sleep(200);
                        break;
                    case ConsoleKey.Escape: break; //esc로 탈출




                }

            }



        }
    }
}
