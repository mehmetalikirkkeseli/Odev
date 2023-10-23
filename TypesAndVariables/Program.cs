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
            double number5 = 10.4;
            decimal number6 = 10.4m;  //virgülden sonra 29 değer tutar
            char character = 'A';
            bool condition = false;
            byte number4 = 255;  //0-255 arası veri tutar.
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;  //long karakter sınırı 19 dur.
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.ReadLine();
        }
    }
}
