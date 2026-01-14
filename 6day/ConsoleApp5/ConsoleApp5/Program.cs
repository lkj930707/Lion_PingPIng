using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ConsoleApp5
{
    
    internal class Program
    {

        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //
            /*
            int num1 = 0;
            int[] num2 = { 1, 2, 3, 4 }; 
            */
            Console.SetBufferSize(80, 25); //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };// 배열 문자열로 그리기 

            int playerX = 0;
            int playerY = 12;
           // ConsoleKeyInfo keyInfo; // 키정보
            Console.CursorVisible = false; //콘솔창 커서 안보이게 하기

            //Sleep(); //프로그램 1초멈춤 
            // 지연 방법 시간 계산해서 1초 루프 
            string jump = " ";
            bool isMissle = false;

            //List<string> multy = new List<string>();
            //List<int> multyX = new List<int>();


            List<(int X, int Y)> missleCount = new List< (int, int)>();

            //int missleX;
            //int missleY;
            //missleX = playerX + 3;
            //missleY = playerY + 1;
            //int m = 0;
            
            int dwTime = Environment.TickCount; // 1/1000초 가 흐름
            while (true) {
                //1초 루프 제작
                if (dwTime + 30 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    int preesKey;
                    if (Console.KeyAvailable)
                    {
                        preesKey = _getch();

                        switch (preesKey)
                        {
                            case 72: // 윗쪽방향키
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1; break; //구석에 처박히면 그자리고정
                            case 75: // 좌측방향키
                                playerX--;
                                if (playerX < 1)
                                    playerX = 1; break; //구석에 처박히면 그자리고정
                            case 77: // 우측방향키
                                playerX++;
                                if (playerX > 79)
                                    playerX = 79; break; //구석에 처박히면 그자리고정
                            case 80: // 하단방향키
                                playerY++;
                                if (playerY < 1)
                                    playerY = 1; break; //구석에 처박히면 그자리고정
                            case 32: //스페

                                missleCount.Add((playerX + 3, playerY + 1));
                                break;

                        }
                        //keyInfo = Console.ReadKey(true); //키입력받기 
                        //switch (keyInfo.Key)
                        //{
                        //    case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        //    case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        //    case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        //    case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth-1) playerX++; break;
                        //}
                    }
                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine(player[i]);
                    }
                        for (int i = missleCount.Count - 1; i >= 0; i--)
                        {

                            var (x, y) = missleCount[i];
                            x++;
                            if (x > 70)
                            {
                                missleCount.RemoveAt(i);
                                break;
                            }
                            else
                            {

                                missleCount[i] = (x, y);
                                Console.SetCursorPosition(x, y);
                                Console.Write("□");

                            }

                        }

                    
                
                                  




                }
            }




           
        }
    }
}
