using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratsky_Comandr
{
    class Program
    {
        static void Main(string[] args)
        {

            


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu();
            }
        }
    }
}
