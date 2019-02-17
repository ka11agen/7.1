using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы");
            int i;
            do
            {
                i = Console.Read();
                if ((char)i == '#')
                    break;
                
                Console.Write((char)i);
            } while (true);
            
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
