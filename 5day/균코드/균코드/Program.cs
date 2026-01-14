using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlTypes;
namespace 균코드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int money = 0;
            int 강화 = 0;
            while (true)
            {
                int ra = rand.Next(1, 4);
                int ra1;

                Console.Clear();
                Console.WriteLine($"강화 게임");
                Console.WriteLine($" 소지금 {money}골드 {강화}강화 ");
                Console.WriteLine($" 돈벌기 1번 ");
                Console.WriteLine($"강화하기 2번");
                Console.WriteLine($" 나가기 3번 ");
                if (강화 >= 5)
                {
                    Console.WriteLine($"강화 5이상 일경우 실패시 강화가 떨어질수있습니다");
                    Thread.Sleep(1000);
                }
                int start;
                start = int.Parse(Console.ReadLine());



                switch (start)
                {
                    case 1:

                        if (ra == 1)
                        {
                            Console.WriteLine($"금화 100원을 벌었습니다");
                            money += 100;

                        }
                        else if (ra == 2)
                        {
                            Console.WriteLine($"금화 50원을 벌었습니다");
                            money += 50;

                        }
                        else
                        {
                            Console.WriteLine($"금화를 벌어오지 못했습니다");


                        }
                        Thread.Sleep(500);
                        break;
                    case 2:
                        {
                            ra1 = rand.Next(1, 4);
                            switch (ra1)
                            {

                                case 1:


                                case 2:

                                case 3:

                                case 4:
                                    if (money >= 50)
                                    {
                                        if (강화 >= 5)
                                        {
                                            switch (ra1)
                                            {

                                                case 1:

                                                case 2:
                                                    Console.WriteLine($"강화 성공");
                                                    강화++;
                                                    money -= 50;
                                                    break;
                                                case 3:
                                                case 4:
                                                    Console.WriteLine($"강화 유지");
                                                    money -= 50; 강화--;
                                                    break;
                                                case 5:
                                                    Console.WriteLine($"강화실패");
                                                    money -= 50; 강화--;
                                                    break;
                                                case 6:
                                                    Console.WriteLine($"강화  대실패");
                                                    강화--; money -= 50;
                                                    break;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"강화 성공");
                                            강화++;
                                            money -= 50;
                                        }
                                    }
                                    else { Console.WriteLine($"돈이 부족합니다"); }


                                    break;
                                case 5:


                                case 6:
                                    if (money >= 50)
                                    {
                                        Console.WriteLine($"강화실패");
                                        money -= 50;

                                    }
                                    else { Console.WriteLine($"돈이 부족합니다"); }

                                    break;


                            }
                            Thread.Sleep(1000);
                            break;

                        }



                }








            }

        }
    }
}
