using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////실수 데이터 형식 : 소숫점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; //단정밀도 실수 (4바이트)
            //double doublePrecision = 3.141592653589793; //배정밀도 실수 (8바이트)
            //decimal highPrecision = 3.1415926535897932384626433832m; //고정밀도 실수 (16바이트)

            //Console.WriteLine($"단정밀도 실수: {singlePrecision}\n" +
            //    $"배정밀도 실수:{doublePrecision}\n고정밀도 실수:{highPrecision}");

            //접미사 사용 : 숫자의 데이터 형식을 명시 
            int integerValue = 100; //기본 정수형 int 
            long longValue = 100L; // 정수형 long 
            float floatValue = 3.14f; //실수형 float
            double doubleValue = 3.14; //실수형 double
            decimal decimalValue = 3.14m; //실수형 decimal 

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);

        }
    }
}
