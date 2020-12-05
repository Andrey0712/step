using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    public class Avto
    {
        public Avto()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Namber { get; set; }
       


        public override string ToString()
        {
            return $"{Id}. {Name} - '{Namber}'";
        }
    }
}
