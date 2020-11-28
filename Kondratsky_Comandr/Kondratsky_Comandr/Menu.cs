using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratsky_Comandr
{ public enum name { FOLDER = 1, CR_FOLDER, CR_InFOLD, CR_FILE, MOVE, Copy, Del, DelFOLDER, Exit }
   
    class Menu
    { 
        public static bool MainMenu()
        { int n = 0;
            Picture. Format_Consol();
            int name, namb;
       
            DriveInfo[] drives = DriveInfo.GetDrives();
            
            foreach (var item in drives)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, n + 4);
                Console.WriteLine(item);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(61, n + 4);
                Console.WriteLine(item);
                n++;

            }
            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 24);
                Console.WriteLine("Сделайте выбор");
                Console.SetCursorPosition(20, 24);
                name = int.Parse(Console.ReadLine());
                

                switch (name)
                {       
                    case 1:
                                                
                        Picture.ClearRitch();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : "); 
                            Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                           ");
                        Console.ResetColor();
                        DirectoryInfo dir = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(61, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir.Name);
                        
                        DirectoryInfo[] dirs = dir.GetDirectories();
                        int n0 = 0;
                        foreach (var item in dirs)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(91,n0+4);
                            Console.WriteLine(item);
                            n0++;

                        }
                        FileInfo[] files = dir.GetFiles();
                        foreach (var item in files)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(91, n0+4);
                            Console.WriteLine(item);
                            n0++;

                        }
                        Console.SetCursorPosition(20, 24);Console.WriteLine(" ");
                                                
                        break;
                                                                    
                    case 2:
                        
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите путь и имя папки : ");
                        Console.SetCursorPosition(35, 25);
                        string name1 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        DirectoryInfo dir1 = new DirectoryInfo(drives[namb].Name);
                        
                        DirectoryInfo newDir = new DirectoryInfo(name1);
                        if (!newDir.Exists)
                        {
                            newDir.Create();
                        }
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(3, 4);
                        Console.WriteLine(newDir);
                        Console.SetCursorPosition(30, 4);
                        int n1 = 0;
                        DirectoryInfo[] dirs1 = newDir.GetDirectories();
                        foreach (var item in dirs1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n1+4);
                            Console.WriteLine(item);
                            n1++;

                        }
                        FileInfo[] files1 = newDir.GetFiles();
                        foreach (var item in files1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n1+4);
                            Console.WriteLine(item);
                            n1++;

                        }
                        Console.SetCursorPosition(20, 24); Console.WriteLine(" ");
                        Console.ReadLine();
                       
                        break;
                       
                    case 3://подпапка
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите путь и имя папки : ");
                        Console.SetCursorPosition(35, 25);
                        string name2 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите имя подпапки : ");
                        Console.SetCursorPosition(35, 25);
                        string name3 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        DirectoryInfo dir2 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir2.FullName);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo newDir1 = new DirectoryInfo(name2);
                        DirectoryInfo newDir2 = newDir1.CreateSubdirectory(name3);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(newDir2.FullName);

                        break;

                    case 4://создать фаил

                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите путь : ");
                        Console.SetCursorPosition(18, 25);
                        string name4 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите имя файла : ");
                        Console.SetCursorPosition(23, 25);
                        string name5 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        DirectoryInfo dir3 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir3.FullName);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo newDir3 = new DirectoryInfo(name4);
                     
                        string path = newDir3.FullName +"\\"+ name5+".txt";
                        FileInfo file = new FileInfo(path);
                        if (!file.Exists)
                            file.Create();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(file.FullName);
                                             
                    break;

                    case 5://переименовать
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                       ");
                        Console.ResetColor();
                        DirectoryInfo dir4 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir4.Name);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo[] dirs4 = dir4.GetDirectories();
                        int n2 = 0;
                        foreach (var item in dirs4)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n2+4);
                            Console.WriteLine(item);
                            n2++;

                        }
                        FileInfo[] files4 = dir4.GetFiles();
                        foreach (var item in files4)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n2+4);
                            Console.WriteLine(item);
                            n2++;

                        }
                        Console.SetCursorPosition(20, 24); Console.WriteLine(" ");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(3, 25);
                        Console.WriteLine("Укажите номер файла для перемещения : ");
                        Console.SetCursorPosition(40, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                             ");
                        Console.ResetColor();
                        FileInfo f = dir4.GetFiles()[namb];
                        Picture.ClearRitch();
                        Console.SetCursorPosition(60, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir4.Name);
                        Console.SetCursorPosition(90, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(f.FullName);
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите имя файла : ");
                        Console.SetCursorPosition(23, 25);
                        string name7 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        string path1 = dir4.FullName + "\\" + name7 + ".txt";
                        f.MoveTo(path1);

                        break;

                    case 6://копировать
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                        ");
                        Console.ResetColor();
                        DirectoryInfo dir5 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir5.Name);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo[] dirs5 = dir5.GetDirectories();
                        int n3 = 0;
                        foreach (var item in dirs5)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n3+4);
                            Console.WriteLine(item);
                            n3++;

                        }
                        FileInfo[] files5 = dir5.GetFiles();
                        foreach (var item in files5)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n3+4);
                            Console.WriteLine(item);
                            n3++;

                        }
                        Console.SetCursorPosition(20, 24); Console.WriteLine(" ");
                       
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(3, 25);
                        Console.WriteLine("Укажите файл для копирования : ");
                        Console.SetCursorPosition(35, 25);
                        namb = int.Parse(Console.ReadLine());
                        Picture.ClearRitch();
                        Console.SetCursorPosition(60, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir5.Name);
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                            ");
                        Console.ResetColor();
                        FileInfo f1 = dir5.GetFiles()[namb];

                        Console.SetCursorPosition(90, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(f1.FullName);
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите имя файла : ");
                        Console.SetCursorPosition(23, 25);
                        string name8 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                        string path2 = dir5.FullName + "\\" + name8 + ".txt";
                        f1.CopyTo(path2);
                        break;

                    case 7://удалить фаил
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                            ");
                        Console.ResetColor();
                        DirectoryInfo dir6 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir6.Name);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo[] dirs6 = dir6.GetDirectories();
                        int n4 = 0;
                        foreach (var item in dirs6)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n4+4);
                            Console.WriteLine(item);
                            n4++;

                        }
                        FileInfo[] files6 = dir6.GetFiles();
                        foreach (var item in files6)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n4+4);
                            Console.WriteLine(item);
                            n4++;

                        }
                        Console.SetCursorPosition(20, 24); Console.WriteLine(" ");
                        
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(3, 25);
                        Console.WriteLine("Укажите файл для удаления : ");
                        Console.SetCursorPosition(30, 25);
                        namb = int.Parse(Console.ReadLine());
                        Picture.ClearRitch();
                        Console.SetCursorPosition(60, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir6.Name);
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                           ");
                        Console.ResetColor();
                        FileInfo f2 = dir6.GetFiles()[namb];
                        Console.SetCursorPosition(90, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(f2.FullName);
                        f2.Delete();
                        break;
                    case 8:
                        Picture.ClearLeft();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите номер диска : ");
                        Console.SetCursorPosition(25, 25);
                        namb = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 25);
                        
                        DirectoryInfo dir7 = new DirectoryInfo(drives[namb].Name);
                        Console.SetCursorPosition(3, 4);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(dir7.Name);
                        Console.SetCursorPosition(30, 4);
                        DirectoryInfo[] dirs7 = dir7.GetDirectories();
                        int n5 = 0;
                        foreach (var item in dirs7)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(31, n5+4);
                            Console.WriteLine(item);
                            n5++;

                        }
                        Console.SetCursorPosition(20, 24); Console.WriteLine(" ");
                        Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Укажите путь и имя папки : ");
                        Console.SetCursorPosition(35, 25);
                        string name9 = Console.ReadLine();
                        Console.SetCursorPosition(3, 25);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                                                              ");
                        Console.ResetColor();
                                               
                        DirectoryInfo dir8 = new DirectoryInfo(name9);
                        dir8.Delete(true);
                        
                        break;
                    case 9:
                        return false;
                       
                    default:
                        Console.WriteLine("Введена не правильная команда");
                        break;
                }
            } ;
        
           
        }

        private static void WriteLine(string message)
        {
            throw new NotImplementedException();
        }
    }
}
