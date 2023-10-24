using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        //String ifadeler
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";
            Console.WriteLine(result2);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
