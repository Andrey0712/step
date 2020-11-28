using System;
using System.Data.SqlClient;


namespace Bookshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConnection = "  Data Source=andreavserver.database.windows.net;Initial Catalog=Bookshop;Persist Security Info=True;User ID=andrey;Password= gtnhjc789!";
            try
            {
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();
                Console.WriteLine("Сконектились с БД :)");
                
                CreatTabl creatTabl = new CreatTabl();
                creatTabl.Add_Tabl(conn);

                
                ///для заполнения таблиц нужно подключить папку с инсертами
                //InsertTabl insertTabl = new InsertTabl();
                //insertTabl.Insert_Tabl(conn);

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
