using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n + SumToN(n - 1); //n+ (n-1)까지의 합
        }
        static void Main(string[] args)
        {
            //재귀 함수 : 자기자신을 호출 
            //1부터 n까지의 합 구하기
            int sum = 10;
            Console.WriteLine($"1부터 {sum}까지의 합 {SumToN(sum)}");
        }
    }
}
