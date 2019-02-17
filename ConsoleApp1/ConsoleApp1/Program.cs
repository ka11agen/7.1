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
            int i, a=0,b=0;
            do
            {
                i = Console.Read();
                if ((char)i == '#')
                    break;
                if ((char)i == '0')
                    a++;
                if ((char)i == '1')
                    b++;
                
            } while (true);
            Console.WriteLine("Символ 0 встречается " + a + ", 1 встерчается " + b + " раз.");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
