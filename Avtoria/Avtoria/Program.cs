using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                try
                {
                    SqlConnection conn = new SqlConnection(strConnection);
                    conn.Open();
                    Console.WriteLine("Сконектились с БД :)");

                    CreatTabl creatTabl = new CreatTabl();
                    creatTabl.Add_Tabl(conn);


                ///для заполнения таблиц нужно подключить папку с инсертами
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
