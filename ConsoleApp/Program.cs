using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                switch (x % 3)
                {
                    case 0:
                        Console.WriteLine("__@");
                        break;
                    case 1:
                        Console.WriteLine("_^@");
                        break;
                    case 2:
                        Console.WriteLine("^_@");
                        break;
                }

                /* if (x % 3 == 0)
                 {
                     Console.WriteLine("__@");
                 }
                 else if (x % 3 == 1)
                 {
                     Console.WriteLine("_^@");
                 }
                 else
                 {
                     Console.WriteLine("^_@");
                 }*/
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
