using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        //Döngüler
        static void Main(string[] args)
        {
            //For döngüsü metoda çevrilmiştir.
            //ForLoop();
            int number = 100;
            //While ifadesi metoda çevrilmiştir.
            WhileLoop(number);
            Console.ReadLine();
        }

        private static void WhileLoop(int number)
        {
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");
        }
    }
}
