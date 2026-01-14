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
            //do-while 문 do에있는 문장은 최소! 무조건 한 번 실행한다
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("조건에 맞지 않아도 실행");
            //    x--;
            //} while (x >0);
            //{

            //}

            string choice;
            int totalPrice = 0;
          
            do
            {
                Console.WriteLine("===메뉴판===");
                Console.WriteLine("1. 짜장  : 5,000원");
                Console.WriteLine("2. 짬뽕  : 6,000원");
                Console.WriteLine("3. 탕수육  : 15,000원");
                Console.WriteLine("4. 볶음밥  : 6,000원");
                Console.WriteLine("0. 주문완료");
                Console.WriteLine(" =================");
                Console.WriteLine("메뉴 번호를 선택하세요");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("짜장면 +5,000원");
                        totalPrice += 5000;
                        break;
                    case "2":
                        Console.WriteLine("짬뽕 +6,000원");
                        totalPrice += 6000;
                        break;
                    case "3":
                        Console.WriteLine("탕수육 +15,000원");
                        totalPrice += 15000;
                        break;
                    case "4":
                        Console.WriteLine("볶음밥 +7,000원");
                        totalPrice += 7000;
                        break;
                    case "0":
                        Console.WriteLine("주문을 완료합니다");
                        
                        break;
                    default:
                        Console.WriteLine("잘못고르셨습니다");
                        break;
                }
                if(choice != "0")
                {
                    Console.WriteLine($"현재 총액: {totalPrice:N0}: 원");
                }
            } while (choice != "0"); // 0입력시까지 반복
            Console.WriteLine($"총 가격은 : {totalPrice:N0} 원 입니다.");
        }

        
    }
}
