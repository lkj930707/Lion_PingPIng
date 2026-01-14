using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int integerNUm = 10;// 정수데이터 
            //float floatNum = 3.14f; // 단정밀도 실수데이터
            //double doublenum = 3.141592;// 배정밀도 실수데이터
            
            //Console.WriteLine("정수형 데이터 : " + integerNUm+"\n"+floatNum+"\n"+doublenum); // 출력

            byte level = 33; //레벨은 0~255까지 가능 
            short attackDamage = 1500;// 공격력은 -32,768 ~ 32,767까지 가능
            int gold = 100000; //골드는 -21억 ~ 21억까지 가능
            long experience = 5000000000L; //경험치는 -9경 ~ 9경까지 가능
            Console.WriteLine("===캐릭터정보=== ");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"공격력 : {attackDamage}");
            Console.WriteLine($"소지금 : {gold:N0}골드"); // N0: 천단위 구분기호 표시
            Console.WriteLine($"경험치 : {experience:N0}XP"); // N0:
            //타입별 최대 값 확인
            Console.WriteLine("\n=== 타입별 최댓값 ===");
            Console.WriteLine($"byte 최댓값 : {byte.MaxValue}");
            Console.WriteLine($"short 최댓값 : {short.MaxValue}");
            Console.WriteLine($"int 최댓값 : {int.MaxValue}");
            Console.WriteLine($"long 최댓값 : {long.MaxValue}");
        }
    }
}
