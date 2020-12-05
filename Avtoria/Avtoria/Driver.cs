using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    public class Driver
    {
         public Driver()
        {
                
        }

        //public Driver(int id, string name, string address, string phoneNumber)
        //{
        //    Id = id;
        //    Name = name;
        //    Address = address;
        //    PhoneNumber = phoneNumber;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        public override string ToString()
        {
            return $"{Id}. {Name} - '{Address}' - {PhoneNumber}";
        }
    }
}
