
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet("adit");
        }
        //replace the terms name with your name
        private static void Greet(string name)
        {
            name = "Put yout name in here";
            Console.WriteLine($"Hello, {name}!");
            Greet2(name); 
            Console.WriteLine("Getting ready to say baye...");
            Bye();

        }

        private static void Greet2(string name)
        {
            name = "put another name here ";
            Console.WriteLine($"how are you, {name}?");
        }

       private static void Bye()
        {
            Console.WriteLine("ok bye!");
        }
    }
}
