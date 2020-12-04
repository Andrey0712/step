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



            }
        }

    
}
