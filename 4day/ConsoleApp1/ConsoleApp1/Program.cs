using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //삼항 연산자
            int a = 10,b = 20;
            string str = "";
            int max = (a > b) ? a : b ;
            Console.WriteLine(max);
            //조건  //트루 : 펄스
            // 삼항 연산자 조건 조건식 ? 참: 거짓

            int score = 85;
            string result = (score >= 60) ? "합격" : "불합격";

            
            Console.WriteLine("===시험 결과===");
            Console.WriteLine("점수 :" +score);
            Console.WriteLine("결과 :" +result);

            //예제 2: 레벨에 따른 등급 
            //레벨 : 45 
            //50보다 크다면 고급 50과 30 사이면 중급 그렇지 않으면 초급

            int level = 45;
            string grade = (level > 50) ? "고급" : (level > 30) ? "중급" : "초급";
            Console.WriteLine("레벨:" + level);
            ////Console.WriteLine("등급:"+ grade);
            


            
            
            
                
        }
    }
}
