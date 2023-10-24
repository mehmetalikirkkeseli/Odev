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
            //EndsWith cümlenin hangi harfle bittiğini kontrol eder.
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            //IndexOf karakter araması yapar.
            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);
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
