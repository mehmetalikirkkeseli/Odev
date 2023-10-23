using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result =  Add2(20,30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //Metotlar
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        //Parametreli Metot
        //Default parametreli metot
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
    }
}
