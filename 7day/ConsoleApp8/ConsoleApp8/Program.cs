using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        //ref 키워드 ! 
        //참조로 전달 ? 먼소리 
        //함수내의 원본을 수정가능
        //ref 는 참조 = 주소까지 지정해서보냄 
        
        static void Halo(ref int a)
        {
            Console.WriteLine(a);
            a++;
            // return a;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Halo(ref a);
            
            Console.WriteLine(a);
        }
    }
}
