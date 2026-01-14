using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //스위치문
            int myNum = 3;
            string str = "";

            
            switch (myNum)
            {
               
                case 1: Console.WriteLine("월"); //브레이크 빠지면 ex case1:case2:
                                                //이런식에서 3에서 브레이크면 123 다잡음
                    break;
                case 2: Console.WriteLine("화");
                    break;
                case 3: Console.WriteLine("수");
                    break;
                default: Console.WriteLine("null");
                    break;
            }
        }
    }
}
