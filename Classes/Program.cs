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
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.ReadLine();
        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added!");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated!");
            }
        }
    }
}
