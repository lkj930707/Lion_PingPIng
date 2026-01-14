using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if 활용 한 줄 if
            //int a = 1;
            //if (a == 1) Console.WriteLine(a);
            //Console.WriteLine("영역밖");
            //int a = 30;
            //if (a>40)
            //{

            //}
            //else if (39 > a && a > 15)
            //{

            //}
            //else
            //{

            //} //Ctrl + K + D 선택부분 이쁘게정리

            //
            int a = 78;
            if(a > 70)
            {
               
                Console.WriteLine("패스");
            }
            if(a >= 60)
            {
                Console.WriteLine("패스2");
            }

        }
    }
}
