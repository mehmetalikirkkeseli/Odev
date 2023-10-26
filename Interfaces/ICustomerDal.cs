using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        //ICustoemrDal adlı interface oluşturulmuştur.
        void Add();
        void Update();
        void Delete();
    }
    class SqlCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    //MySqlCustomerDal class'ı oluşturulmuştur.
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MqSql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
