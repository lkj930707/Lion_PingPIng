using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static int HP = 100;

        static void Attack()
        {
            HP--;
            Console.WriteLine("공격을받음");
        }

        static void Main(string[] args)
        {
            Attack();
            Console.WriteLine($"HP : {HP}");
            
        }
    }
}
