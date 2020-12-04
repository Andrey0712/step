using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    class CreatTabl
    {
        public void Add_Tabl(SqlConnection conn)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            try
            {
                command.CommandText = File.ReadAllText(@"C:\step\Avtoria\Avtoria\creatTabl\Tabl_Driver.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу Tabl_Driver - созданно");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }

            try
            {
                command.CommandText = File.ReadAllText(@"C:\step\Avtoria\Avtoria\creatTabl\Tabl_Avto.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу Tabl_Avto.sql - созданно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }
            try
            {
                command.CommandText = File.ReadAllText(@"C:\step\Avtoria\Avtoria\creatTabl\Tabl_Avto_Driver.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу Tabl_Avto_Driver.sql - созданно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }
            
    }   }
}
