using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void SwapT(out int a, out int b)
        {

             a = 10;
             b = 20;
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //// x와 y의 값을 바꾸는 법? 스왑 swap
            //int temp;
            //temp = x;
            //x = y;
            //y = temp;
            //Console.WriteLine(x+" "+y);

            int a = 10;
            int b = 20;

            Swap(ref a, ref b);
            Console.WriteLine(a+" "+b);

            SwapT(out a, out b);
            Console.WriteLine(a+" "+b);

            
        }
    }
}
