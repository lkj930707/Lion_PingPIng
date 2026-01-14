using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////증감 연산자
            //int a = 5;
            //a++; //후위증가
            //Console.WriteLine(a); //6
            //--a; //전위감소
            //Console.WriteLine(a); //5

            //전위 후위 증가시 차이  전위는 일단 증가or 감소 , 후위는 컴파일 시점에서 증가나 감소되지않고 다음라인에서 연산
            //int count = 5;
            //Console.WriteLine(++count); //6 
            //Console.WriteLine(count++); //6 컴파일 후 다음라인 7 
            //Console.WriteLine(count); //7


            //int killCount = 0;
            //int bulletCount = 30;
            //int countDown = 3;
            //Console.WriteLine("===몬스터 처치===");
            //Console.WriteLine("고블린 처치!"+ "(킬카운트:)"+ ++killCount);
            //Console.WriteLine("오크 처치!"+ "(킬카운트:)" + ++killCount); 
            //Console.WriteLine("드래곤 처치!"+ "(킬카운트:)" + ++killCount);
            //Console.WriteLine("총 처치:"+ "(킬카운트:)" + killCount);
            //Console.WriteLine("\n===사격===" );
            //Console.WriteLine("(남은 총알: )"+ bulletCount--);
            //Console.WriteLine("발사!"+ "(남은 총알:)"+ bulletCount--);
            //Console.WriteLine("발사!"+ "(남은 총알:)"+ bulletCount--);
            //Console.WriteLine("발사!"+ "(남은 총알:)"+ bulletCount);
            //Console.WriteLine("\n===카운트 다운===");
            //Console.WriteLine(countDown--);
            //Console.WriteLine(countDown--);
            //Console.WriteLine(countDown);


            //관계형 연산자
            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);

            //논리 연산자
            //bool a = true;
            //bool b = true;

            //Console.WriteLine(a && b); //true true = false
            //Console.WriteLine(!a && b); //둘다 true 여야 true
            //Console.WriteLine(a && !b); //둘다 true 여야 true
            //Console.WriteLine(!a && !b); //둘다 false 면 false

            //Console.WriteLine("\n" + (a || b));  //둘중하나 true면 true
            //Console.WriteLine("\n" + (!a || b));  //둘중하나 true면 true
            //Console.WriteLine("\n" + (a || !b));  //둘중하나 true면 true
            //Console.WriteLine("\n" + (!a || !b));  //둘다 false면 false

            // !  == NOT 연산자 
            //bool a = true;
            //Console.WriteLine(!a); //false

            //비트연산자 
            //비트 단위로 논리연산을 실행

            //int x = 5; // 0101
            //int y = 3; // 0011

            //Console.WriteLine(x & y); // 0001 
            ////  0101
            ////X 0011
            ////  -----
            ////  0001   = 1

            //Console.WriteLine(x | y); // 0111
            //  0101
            //  0011
            //  ----
            //  0111   = 7 

            ///////////////////////////////////////////
            //
            //int x = 5; //0101
            //int y = 3; //0011

            //string binary = Convert.ToString(x & y, 2); // AND 연산자 == 둘다 1일때 1
            //Console.WriteLine(binary.PadLeft(8, '0')); //00000001
            //binary = Convert.ToString(x | y, 2); // OR 연산자 == 하나라도 1이면 1
            //Console.WriteLine(binary.PadLeft(8, '0')); //00000111
            //binary = Convert.ToString(x ^ y, 2); // XOR 연산자 == 다를때 1 같을때 0 
            //Console.WriteLine(binary.PadLeft(8, '0')); //00000110
            //binary = Convert.ToString(~x, 2);  //이진수 부호 비트 포함 + NOT 연산자
            //Console.WriteLine(binary.PadLeft(8, '0')); //11111111111111111111111111111010



            //쉬프트 연산자 Shift 
            int value = 4; // 0100
            string binary = Convert.ToString(value, 2);
            // << >> : 비트들을 왼쪽이나 오른쪽으로 이동
            Console.WriteLine(binary.PadLeft(8, '0')); // 왼쪽으로 1비트 이동 1000 = 8
            binary = Convert.ToString(value >> 1, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
        }
    }
}
