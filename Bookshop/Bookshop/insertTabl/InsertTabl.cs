using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop
{
    class InsertTabl
    {
        public void Insert_Tabl(SqlConnection conn)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            try
            {
                command.CommandText = File.ReadAllText(@"C:\ШАГ\Bookshop\Bookshop\insertTabl\insert_Tabl_Book.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу TablBook.sql - заполненно");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }

            try
            {
                command.CommandText = File.ReadAllText("C:\\ШАГ\\Bookshop\\Bookshop\\insertTabl\\insert_Tabl_Author.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу TablAuthor.sql - заполненно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }
            try
            {
                command.CommandText = File.ReadAllText(@"C:\ШАГ\Bookshop\Bookshop\insertTabl\insert_Tabl_BookAuthor.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу TablBookAuthor.sql - заполненно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }
            try
            {
                command.CommandText = File.ReadAllText(@"C:\ШАГ\Bookshop\Bookshop\insertTabl\insert_Tabl_BookForSale.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу TablBookForSale.sql - заполненно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }



        }
    }
}
