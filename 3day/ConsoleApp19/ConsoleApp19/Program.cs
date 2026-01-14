using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //형식변환 캐스팅 
            //1. 암시적 변환 작은>큰 
            //int smallNum = 100;
            //long bigNum = smallNum; // int > long 암시적 자동 변환
            //double doubleNUm = smallNum; // int > double 암시적 자동변환 

            //Console.WriteLine("===암시적 변환===");
            //Console.WriteLine($"int :{smallNum.GetType()}");
            //Console.WriteLine($"long :{bigNum}");
            //Console.WriteLine($"double :{doubleNUm}");

            //2. 명시적 변환 큰 > 작은
            //double pi = 3.14;
            //int intPi = (int)pi; // 소숫점 버려출력 (명시적 캐스팅)

            //Console.WriteLine("===명시적 변환===");
            //Console.WriteLine($"double :{pi}"); // 3.14
            //Console.WriteLine($"int :{intPi}"); // 3

            //int float double char long <<옛날부터있던 형식들 
            //string 커스터 마이징한놈 

            //3. 문자열 >숫자로 변환 
            string scoreText = "100";
            int score = int.Parse(scoreText); // 문자열> 정수 

            string priceText = "11.11";
            double price = double.Parse(priceText); //문자열 > 실수 

            Console.WriteLine("\n===문자열 변환===");
            Console.WriteLine($"점수(문자열): {score}>숫자 : {score}");
            Console.WriteLine($"가격(문자열: {priceText}>숫자 : {price})");

            //숫자 > 문자열 
            int playerLevel = 95;
            string levelText = playerLevel.ToString();// 숫자> 문자열 

            ////트라이 파스 
            //if(int, tryParse(priceText,out int num))
            //{
            //    //성공
            //}
            //else 
            //{
            //    //실패
            //}




        }
    }
}
