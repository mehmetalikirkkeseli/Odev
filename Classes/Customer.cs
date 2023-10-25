using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {   //Property eklemek için prop kısayolu kullanılır.
        //Field tanımlama
        //public string FirstName;
        //private string _firstName;
        //public string FirstName
        //{
        //    //Encapsulation
        //    get
        //    { return "Mrs. " + _firstName; }
        //    set
        //    { _firstName = value; }
        //}

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
