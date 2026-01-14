using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //대장장이 키우기 
            //1. 나무캐기  >돈을범
            //2. 장비뽑기
            //3. 나가기
            Random rand = new Random();
            Console.WriteLine("대장장이 키우기");
            int pmoney = 100;
            int input;
            int rnd;
            Thread.Sleep(500);

            //무한반복
            while (true)
            {
                Console.Clear(); //콘솔지우기 
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //인풋에 입력받기

                if (input == 1)//나무캐기 화면
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기(x)");
                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 :" + pmoney);
                        if(str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if (input == 2) //장비뽑기
                {
                    if (pmoney >= 1000) //돈확인
                    {
                        for(int i =1; i<=20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            if(rnd == 1) //1퍼센트
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }else if(rnd >=2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(100); //0.5초정도로 뽑혀라
                        }
                        Thread.Sleep(2000); //스샷시간
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("돈부족하다 나무나캐자..");
                        
                    }

                }else if (input==3)
                {
                    Console.WriteLine("게임을 나갑니다.");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

            }
        }
    }
}
