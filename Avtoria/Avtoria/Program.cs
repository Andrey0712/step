using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    
            class Program
        {
      
        static void Main(string[] args)
            {
            
                string strConnection = "  Data Source=PK;Initial Catalog=Avtoria;Integrated Security=True";
            //string strConnection = "Data Source=serverpu816.database.windows.net;Initial Catalog=test;User ID=pu816;Password=Qwerty1*";
            try
                {
                    SqlConnection conn = new SqlConnection(strConnection);
                    conn.Open();
                    Console.WriteLine("Сконектились с БД :)");

                    CreatTabl creatTabl = new CreatTabl();
                    creatTabl.Add_Tabl(conn);
                                
                InsertTabl insertTabl = new InsertTabl();
                insertTabl.Insert_Tabl(conn);

                conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                    throw;
                }

            DriverServer driverService = new DriverServer(strConnection);
            AvtoServis avtoService = new AvtoServis(strConnection);
            Avto_driverServis a_d_Servis = new Avto_driverServis(strConnection);
            Console.WriteLine("для работы с БД нажмите  Ent");
            Console.ReadLine();
            int counter = 1;
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                while (keyInfo.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }Console.WriteLine("1. Работаем с табличкой Driver");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }Console.WriteLine("2. Работаем с табличкой Avto");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("3. Работаем с табличкой Avto_Driver");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (counter == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("4. Вихід");
                    Console.ForegroundColor = ConsoleColor.White;

                    keyInfo = Console.ReadKey();
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.DownArrow:
                            {
                                if (counter <5)
                                {
                                    counter++;
                                }
                                else
                                {
                                    counter = 1;
                                }
                                break;
                            }
                        case ConsoleKey.UpArrow:
                            {
                                if (counter > 1)
                                {
                                    counter--;
                                }
                                else
                                {
                                    counter = 4;
                                }
                                break;
                            }

                    }
                }

                switch (counter)
                {
                    case 1: { driverService.MenuDriver();  break; }
                    case 2: { avtoService.MenuAvto(); break; }
                    case 3: { a_d_Servis.MenuAvto_Driver(); break; }
                    case 4: { return; }
                }
            }

        }


    }
        }

    

