using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SwordGrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //드가자 검키우기 
            //

            const int hammer = 8;
            const int shop = 30;

            int myPositionX = 10;
            int myPositionY = 10;

            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);

            Console.CursorVisible = false;

            Random random = new Random();

            string sword = "맨 손"; //검 종류 
            int gold = 50000; // 소지골드
            int needGold = 100;// 강화필요골드
            bool isSword = false;
            int ranWeapon;
            int per;
            int rank=0;
            firstHome:
            ConsoleKeyInfo keyInfo;
            while (true)
            {
           

                Console.Clear();
                Console.SetCursorPosition(hammer, hammer-5); // 대장간위치
                Console.Write("🔨");
                Console.SetCursorPosition(shop, shop-25); // 상점위치
                Console.Write("🛍");
                Console.SetCursorPosition(myPositionX, myPositionY); // 내 기본위치
                Console.Write("🔪");
                

                if( Math.Abs(myPositionX - hammer) < 2  && Math.Abs(myPositionY - (hammer-5)) < 1) 
                {
                    Console.WriteLine("'대장간'에 진입합니다. (Enter)");
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("대장간 입장 중...");
                        goto smith;

                    }
                    
                }
                if (Math.Abs(myPositionX - shop) < 2 && Math.Abs(myPositionY - (shop - 25)) < 1)
                {
                    Console.WriteLine("'상점'에 진입합니다. (Enter)");
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("상점 입장 중...");
                        Thread.Sleep(500);
                        goto shop;
                    }

                }

                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (myPositionY > 1 ) myPositionY--; break;
                    case ConsoleKey.DownArrow: if (myPositionY < Console.WindowHeight - 2) myPositionY++; break;
                    case ConsoleKey.LeftArrow: if (myPositionX > 1) myPositionX--; break;
                    case ConsoleKey.RightArrow: if (myPositionX < Console.WindowWidth -2) myPositionX++; break;
                    case ConsoleKey.Escape:
                            
                        break;
                }




            }
        smith:
            while (true)
            {

                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("===대장간===");
                Console.WriteLine($"현재무기: {sword}+({rank})강");
                Console.WriteLine($"보유Gold: {gold}G");
                Console.WriteLine($"무기를 강화하려면 비용은{rank*needGold}라네 원한다면(Enter)키를 누르시게");
                Console.WriteLine("대장간에서 나가려면 (Esc)키를 누르시게");
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (!isSword)
                    {
                        Console.Clear();
                        Console.WriteLine("===대장간===");
                        Console.WriteLine("자네 검이 없군.. 이거받게");
                        ranWeapon = random.Next(0, 5);
                        switch (ranWeapon)
                        {
                            case 0 : sword = "꽃다발"; break;
                            case 1 : sword = "몽둥이"; break;
                            case 2 : sword = "철검"; break;
                            case 3 : sword = "광선검"; break;
                            case 4 : sword = "무형검"; break;
                        }
                        Console.WriteLine($"낡은 {sword}를 얻었다.");
                        isSword = true;

                    }
                    else
                    {
                        if (gold > needGold)
                        {

                            Console.WriteLine("강화중.");
                            Thread.Sleep(500);
                            Console.WriteLine("강화중..");
                            Thread.Sleep(500);
                            Console.WriteLine("강화중...");
                            per = random.Next(0, 11);
                            gold -= (needGold*rank);
                            if (per > 0 && per < 8)
                            {
                                rank++; 
                                Console.WriteLine("성공했군 역시나야!");
                                Console.WriteLine($"{sword} ({rank})강");
                                
                            }
                            else if (per > 7 && per < 10)
                            {
                                Console.WriteLine("부숴지진않았으니뭐..");
                                Console.WriteLine($"{sword} ({rank})강");
                                
                            }
                            else
                            {
                                rank = 0;
                                isSword = false;
                                Console.WriteLine("파괴되어버렸군..");
                                Console.WriteLine("쟌넨...");
                                sword = "맨 손";
                                
                            }
                            Thread.Sleep(500);


                        }
                    }

                    
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("대장간에서 나갑니다");
                    goto firstHome;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("===대장간===");
                    Console.Write("잘못눌렀다네...");
                }
            }
        shop:
            while (true)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("===상점===");
                Console.WriteLine($"현재무기: {sword}+({rank})강");
                Console.WriteLine($"보유Gold: {gold}G");
                Console.WriteLine("무기를 팔려면 (Enter)키를 눌러봐");
                Console.WriteLine("상점에서 나가려면 (Esc)키를 눌러봐");

                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (sword == "맨 손")
                    {
                        Console.WriteLine("아무것도 없으면서 뭘 판다는거야!");
                        Console.WriteLine("대장간으로 보내줄테니 잘가라구");
                    }
                    else { 
                    Thread.Sleep(500);
                    Console.WriteLine($"이야 {rank}강이네? {rank * rank * 600}G 만큼 쳐주지");
                    Thread.Sleep(500);
                    Console.WriteLine("대장간으로 보내줄테니 잘가라구");
                    
                    }
                    Thread.Sleep(500);

                    goto smith;

                }

            }

            


            
        }
    }
}
