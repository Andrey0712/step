using System;
using System.Collections.Generic;
using System.Text;

namespace Film_library
{
    public class CustomComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}