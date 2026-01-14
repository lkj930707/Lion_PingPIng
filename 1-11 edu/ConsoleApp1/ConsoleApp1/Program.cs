using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetBufferSize(80, 25); //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            string[] player = new string[]
            {
                "◣",
                "■▶",
                "◤"
            };

            

            Console.CursorVisible = false;
            int playerX = 0, playerY = 12;

            int sleepTime = Environment.TickCount; //1/1000초 카운트

            List<(int X, int Y)> missleCount = new List<(int X, int Y)>(); //가변 배열
            while (true)
            {
                if (Environment.TickCount -  sleepTime >= 20)
                {
                    sleepTime = Environment.TickCount;
                    Console.Clear();
                    int pressKey;
                    if (Console.KeyAvailable)
                    {
                        pressKey = _getch();
                        switch (pressKey)
                        {
                            case 72: if (playerY > 0) playerY--;   break;//상단
                            case 80: if (playerY < Console.WindowHeight+2) playerY++;   break;//하단
                            case 75: if (playerX > 0) playerX--;   break; //좌측
                            case 77: if (playerX < Console.WindowWidth -2) playerX++;   break; //우측
                            case 32:
                                missleCount.Add((playerX+3,playerY+1));
                                break; //스페이스
                        }
                    }
                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i); //커서x좌표y좌표로 셋팅
                        Console.WriteLine(player[i]); //그려
                    }
                    for (int i= missleCount.Count -1; i >= 0; i--)
                    {
                        (int x,int y) = missleCount[i]; //미사일카운트배열 i번째에있는 x,y를
                        //각각 x,y변수에 넣음
                        x++;
                        if (x > 70)
                        {
                            missleCount.RemoveAt(i);
                            continue;
                        }
                        else
                        {
                            
                            missleCount[i] = (x, y);
                            
                            Console.SetCursorPosition(x , y );
                            Console.Write("🚀");

                        }

                        
                    }
                    
                }
                else
                {
                    Thread.Sleep(1);
                }

            }

        }
    }
}
