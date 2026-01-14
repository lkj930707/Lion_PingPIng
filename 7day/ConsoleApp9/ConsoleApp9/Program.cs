using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Attack(out string a,int b,out int atk,out int def)
        {
            a = "단단 한가?";
            atk = 10;
            def = 20;
            atk++;
            def++;
            a += " : 탱커";
        }
        static void Main(string[] args)
        {
            string a = "";
            int atk;
            int def;

            Attack(out a, 10, out atk, out def);
            Console.WriteLine("공" + atk);
            Console.WriteLine("방" + def);
            Console.WriteLine(a);
        }
    }
}
