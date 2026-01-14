using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char 형식 : 단일 문자를 표현 
            //char letter = 'A'; //문자 'A'를 저장
            //char simbol = '#'; // 특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장 문자형태의 9이므로 숫자가 아님

            //Console.WriteLine($"{letter}\n{simbol}\n{number}");
            
            //출력
            //===== 캐릭터 능력치 =====
            //float   이동속도: 5.5
            //double  공격속도: 1.25
            //decimal 아이템가격: 12.99
            float moveSpeed = 5.5f; 
            double attackSpeed = 1.25; 
            decimal itemPrice = 12.99m; 

            Console.WriteLine("===== 캐릭터 능력치 =====");
            Console.WriteLine("이동속도 "+moveSpeed);
            Console.WriteLine("공격속도 "+attackSpeed);
            Console.WriteLine("아이템 가격 "+itemPrice);


        }
    }
}
