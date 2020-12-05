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
            int action = 0;
            do
            {
                Console.WriteLine("0. Выход");
                Console.WriteLine("1. Работаем с табличкой Driver");
                Console.WriteLine("2. Работаем с табличкой Avto");
                Console.WriteLine("3. Работаем с табличкой Avto_Driver");
                Console.Write("->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            driverService.MenuDriver();
                            break;
                        }
                    case 2:
                        {
                            avtoService.MenuAvto();
                            break;
                        }
                    case 3:
                        {
                            a_d_Servis.MenuAvto_Driver();
                            break;
                        }
                   
                }

            } while (action != 0);

           


        }
        }

    
}
