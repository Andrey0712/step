using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratsky_Comandr
{
    class Picture
    {
        public static void Format_Consol()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ResetColor();
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;



            for (int y = 3; y <= 22; y++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, y);
                Console.WriteLine("|");
                Console.SetCursorPosition(58, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(28, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(87, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(118, y);
                Console.WriteLine("|");
                Console.ResetColor();
            }
            for (int y = 23; y <= 25; y++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, y);
                Console.WriteLine("|");
                Console.SetCursorPosition(118, y);
                Console.WriteLine("|");
                Console.ResetColor();
            }
            for (int y = 27; y <= 28; y++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, y);
                Console.WriteLine("|");
                Console.SetCursorPosition(13, y);
                Console.WriteLine("||");              
                Console.SetCursorPosition(28, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(42, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(58, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(73, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(87, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(103, y);
                Console.WriteLine("||");
                Console.SetCursorPosition(118, y);
                Console.WriteLine("|");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("======================================================================================================================" );
            Console.SetCursorPosition(1, 23);
            Console.WriteLine("======================================================================================================================");
            Console.SetCursorPosition(1, 26);
            Console.WriteLine("======================================================================================================================");

            Console.SetCursorPosition(1, 28);
            Console.WriteLine("======================================================================================================================");
            Console.SetCursorPosition(50, 1);
            Console.WriteLine(" My commander ");

           
            Console.SetCursorPosition(3, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.FOLDER+ "  1");
            Console.SetCursorPosition(16, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.CR_FOLDER + "  2");
            Console.SetCursorPosition(31, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.CR_InFOLD + " 3");
            Console.SetCursorPosition(45, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.CR_FILE + "  4");
            Console.SetCursorPosition(61, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.MOVE + "  5");
            Console.SetCursorPosition(77, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.Copy + "  6");
            Console.SetCursorPosition(90, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.Del + "  7");
            Console.SetCursorPosition(106, 27); Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.DelFOLDER + "  8");
            
           

            Console.ResetColor();
        }

        public static void ClearLeft()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    Console.SetCursorPosition(x + 2, y + 4);
                    Console.WriteLine(" ");
                }

                for (int x = 0; x < 28; x++)
                {
                    Console.SetCursorPosition(x + 30, y + 4);
                    Console.WriteLine(" ");
                }
            }
            Console.ResetColor();

        }
               
        public static void ClearRitch()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    Console.SetCursorPosition(x + 60, y + 4);
                    Console.WriteLine(" ");
                }

                for (int x = 0; x < 29; x++)
                {
                    Console.SetCursorPosition(x + 89, y + 4);
                    Console.WriteLine(" ");
                }
            }
            Console.ResetColor();

        }
    }
}
