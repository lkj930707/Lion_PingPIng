using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string greeting;  //문자열 변수 선언
            //greeting = "알로하"; // 변수에 대입
            ////출력
            //Console.WriteLine(greeting); 

            //변수초기화
            //int score = 50;  // 정수형 변수 선언과 초기화
            //double temperatere = 33.5; //실수형 변수 선언화 초기화
            //string city = "서울"; // 문자열 변수 선언과 초기화
            //Console.Write(score +"\n"+temperatere+"\n"+city);

            //방법1: 선언후 할당 
            int health;
            health = 100;

            //방법2: 선언과 동시에 할당(초기화)
            int maxHealth = 150;
            int dagage = 15;

            Console.WriteLine("체력 : " + health + "/" + maxHealth);
            Console.WriteLine("데미지 : " + dagage);
           
            



        }
    }
}
