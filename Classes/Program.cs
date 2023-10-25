using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        //Classlar
        static void Main(string[] args)
        {
            //Class çağırma
            //CustomerManager class'ı ayrı oluşturulmuştur.
            //ProductManager class'ı ayrı oluşturulmuştur.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();
        }
        
    }
}
