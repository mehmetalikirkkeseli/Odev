using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        //Çoklu implementasyon
        static void Main(string[] args)
        {
            //IWorker interface'i çağrılmıştır.
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            //IEat interface'i çağrılmıştır.
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    //IWorker interface'i oluşturulmuştur.
    interface IWorker
    {
        void Work();

    }
    //IEat interface'i oluşturulmuştur.
    interface IEat
    {
        void Eat();
    }
    //ISalary interface'i oluşturulmuştur.
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }

        void IEat.Eat()
        {
            
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
