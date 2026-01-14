using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int value = 0;

            //string binary;
            //binary = Convert.ToString(value >> 1, 2);
            //Console.WriteLine(binary.PadLeft(8, '0'));


            //*
            //int inven = 0; //0000 0000
            //Console.WriteLine($"초기 인벤 : {Convert.ToString(inven, 2).PadLeft(8, '0')}" );

            ////슬롯번호 
            //int slot1 = 1; //활
            //int slot2 = 2; //지팡이

            ////슬롯 0에 활 추가 
            //inven = inven | (1 << slot1); //
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"초기 인벤 : {Convert.ToString(inven, 2).PadLeft(8, '0')}");
            //

            int test = 1;
            string binary;
            binary = Convert.ToString(test, 2);
            Console.WriteLine(binary.PadLeft(8,'0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(1 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(2 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(4 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(8 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(16 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(32 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);

            Console.Clear();
            binary = Convert.ToString(64 << test, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            Thread.Sleep(1100);
        }
           
    }
}
