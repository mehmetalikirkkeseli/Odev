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
            var result5 = sentence.IndexOf("namee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            //Insert cümleye ekleme yapmak için kullanılır.
            var result8 = sentence.Insert(0,"Hello, ");
            //Substring metni parçalar.
            var result9 = sentence.Substring(3,4);
            //ToLower harfleri küçük harf yapar.
            var result10 = sentence.ToLower();
            //ToUpper harfleri büyük harf yapar.
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            //Remove metinden belli bir indeksten sonraki bölümü atar.
            var result13 = sentence.Remove(2);
            Console.WriteLine(result13);
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
