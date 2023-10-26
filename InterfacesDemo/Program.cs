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
    class Manager : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
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
}
