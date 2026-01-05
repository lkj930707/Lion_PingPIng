using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int num_2;   변수선언   
            //묶음주석 == Ctrl + k +c 
            //double num_pi;
            //주석해제 == ctrl + k + u
            //string str;      
            
            int num_2 = 1; //선언및 초기화
            double num_pi = 3.14;
            string str = "hello world"; 

            //num_2 = 1;
            //num_pi = 3.14;
            //str = "hello world";

            Console.WriteLine($"숫자:{num_2} 파이:{num_pi} 문자:{str}");
            Console.WriteLine("숫자:{0} 파이:{1} 문자:{2}",num_2,num_pi,str);
            Console.WriteLine("숫자:"+num_2+" 파이:"+num_pi+" 문자:"+str);



        }
    }
}
