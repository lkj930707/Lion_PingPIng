using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자 계산할때 사용
            //int a = 5, b = 3;
            //int sum = a + b; //산술 연산자 +
            //bool isEqual = (a == b); //비교 연산자 
            //Console.WriteLine("두숫자의합은?"+sum+", 같은가? " +isEqual);

            //산술 연산자: 사칙연산 (+, -, *, /, 😵
            //비교 연산자: 크기 비교(==, !=, <, >, <=, >=😆
            //논리 연산자: 논리 판단(&&, ||, !)
            //대입 연산자: 값 저장(=, +=, -=, *=, /=)
            //증감 연산자: 1씩 증가/ 감소(++, --)

            //단항 연산자
            //int num = 5;
            //Console.WriteLine(+num); //양수출력
            //Console.WriteLine(-num); //양수출력

            //bool flag = true;
            //Console.WriteLine(!flag); //false 출력 논리부정

            //int c = 10, d = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //나머지 연산자: 왼쪽 피연산자를 오른쪽 피연산자로 나눈 나머지 값을 반환

            //문자열의 연결 
            //string alpha = "Hello";
            //string beta = "World";

            //Console.WriteLine(alpha + beta);
            //Console.WriteLine(alpha + " " + beta);

            int e = 5; 
            const int F = 4;
            int sum_a = 0;
           // sum = e + f;
            //할당연산자 
            //e += f; // e = e + f 
            Console.WriteLine(e+=F);
            //e = 5;
            //e -= f; // e = e - f
            Console.WriteLine(e-=F);
            //e = 5;
            //e *= f; // e = e * f
            Console.WriteLine(e*=F);
           // e = 5;
            //e /= f; // e = e / f
            Console.WriteLine(e/=F);
            //e = 5;
            //e %= f; // e = e % f
            Console.WriteLine(e%=F);

        }
    }
}
