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
            ConsoleKeyInfo keypress;
            do
            {
                keypress = Console.ReadKey();

                if (keypress.Key == ConsoleKey.Enter)
                    Console.WriteLine();
                if (keypress.KeyChar == '0')
                    a++;
                if (keypress.KeyChar == '1')
                    b++;

            } while (keypress.KeyChar != '#');
            Console.WriteLine("\nСимвол 0 встречается " + a + ", 1 встерчается " + b + " раз.");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
