using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    class Avto_Driver
    {
        public Avto_Driver()
        {

        }

        public int Id { get; set; }
        public string AvtoId { get; set; }
        public string DriverId { get; set; }



        public override string ToString()
        {
            return $"{Id}. '{AvtoId}' - '{DriverId}'";
        }
    }
}
