using System;
using System.Data.SqlClient;
using System.IO;


namespace Bookshop
{
    class CreatTabl
    {
        
        public void Add_Tabl(SqlConnection conn)
        {
                           
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                
                try
                {
                    command.CommandText = File.ReadAllText("createTabl\\TablBook.sql");
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблицу TablBook.sql - созданно");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибочка вышла : " + ex.Message);
                }

                try
                {
                    command.CommandText = File.ReadAllText("createTabl\\TablAuthor.sql");
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблицу TablAuthor.sql - созданно");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибочка вышла : " + ex.Message);
                }
                try
                {
                    command.CommandText = File.ReadAllText("createTabl\\TablBookAuthor.sql");
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблицу TablBookAuthor.sql - созданно");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибочка вышла : " + ex.Message);
                }
                try
                {
                    command.CommandText = File.ReadAllText("createTabl\\TablBookForSale.sql");
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблицу TablBookForSale.sql - созданно");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибочка вышла : " + ex.Message);
                }
               
            
            
        }
    }
}
