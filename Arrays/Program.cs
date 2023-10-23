using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        //Diziler
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            string[] students2 = { "Engin", "Derin", "Salih" };
            students2[3] = "Ahmet";
            
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
