using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForms
{
    public class SearchUser
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Page { get; set; }
        public int CountShowOnePage { get; set; } = 10;//кол записей на 1 стр
    }
}
