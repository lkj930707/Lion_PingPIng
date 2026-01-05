using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string join =   "Join ARK";
            string host =   "HOST/LOCAL";
            string option = "OPTIONS";
            string guide =  "SURVIVAL GUIDE";
            string credit = "CREDITS";
            string exit =   "EXIT";
            
            Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃                                          ┃");
            Console.WriteLine($"┃ {join}                                 ┃");
            Console.WriteLine($"┃ {host}                               ┃");
            Console.WriteLine($"┃ {option}                                  ┃");       
            Console.WriteLine($"┃ {guide}                           ┃");
            Console.WriteLine($"┃ {credit}                                  ┃");
            Console.WriteLine($"┃ {exit}                                     ┃");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
