﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            byte number4 = 255;  //0-255 arası veri tutar.
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;  //long karakter sınırı 19 dur.
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.ReadLine();
        }
    }
}
