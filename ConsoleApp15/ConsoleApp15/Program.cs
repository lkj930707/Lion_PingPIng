using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("안");
            //Thread.Sleep(200);
            //Console.Clear();
            //Console.Write("안녕");
            //Thread.Sleep(200);
            //Console.Clear();
            //Console.Write("안녕하");
            //Thread.Sleep(200);
            //Console.Clear();
            //Console.Write("안녕하세");
            //Thread.Sleep(200);
            //Console.Clear();
            //Console.Write("안녕하세요");

            //과제
            //저번시간 만들었던 UI를 정해서
            //비주얼 하게 만들어보세요
            bool isStarting = true;
            int time = 1;

            //Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃ Join                                     ┃");
            //Console.WriteLine($"┃ Host                                     ┃");
            //Console.WriteLine($"┃ Option                                   ┃");
            //Console.WriteLine($"┃ Guide                                    ┃");
            //Console.WriteLine($"┃ Creadit                                  ┃");
            //Console.WriteLine($"┃ Exit                                     ┃");
            //Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            //Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┃                                          ┃");
            //Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            do
            {
              

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃ Join                                     ┃");
                Console.WriteLine($"┃ Host                                     ┃");
                Console.WriteLine($"┃ Option                                   ┃");
                Console.WriteLine($"┃ Guide                                    ┃");
                Console.WriteLine($"┃ Creadit                                  ┃");
                Console.WriteLine($"┃ Exit                                     ┃");
                Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                Thread.Sleep(300);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┃                                          ┃");
                Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Thread.Sleep(200);
                time++;

            } while (time < 100);


        }
    }
}
