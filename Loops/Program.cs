﻿using System;
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
            
            //While ifadesi metoda çevrilmiştir.
            //WhileLoop(number);
            //Do-while ifadesi metoda çevrilmiştir.
            //DoWhileLoop();
            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
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
