using Bogus;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria

{
    class InsertTabl
    {
        public void Insert_Tabl(SqlConnection conn)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            try
            {
                command.CommandText = File.ReadAllText(@"C:\step\Avtoria\Avtoria\insertTable\insert_tabl_Avto.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу Avto - заполненно");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }

            try
            {
                List<Driver> myList = new List<Driver>();
                var faker = new Faker<Driver>("uk");
                faker.RuleFor(c => c.Name, (f, c) => f.Name.FullName());
                faker.RuleFor(c => c.Address, (f, c) => f.Address.FullAddress());
                faker.RuleFor(c => c.PhoneNumber, (f, c) => f.Phone.PhoneNumber());


                for (int i = 0; i < 10; i++)
                {
                    myList.Add(faker.Generate());
                }

                foreach (var item in myList)
                {
                    string query = $"INSERT INTO [dbo].[Driver] ([Name] ,[Address] ,[PhoneNumber]) " +
                        $"VALUES (N'{item.Name}',  +'{item.Address}', +'{item.PhoneNumber}' )";
                    
                    
                    SqlCommand command1 = new SqlCommand(query, conn);
                command1.ExecuteNonQuery();
                   
                }
                
                Console.WriteLine("Таблицу Driver.sql - заполненно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }

            try
            {
                command.CommandText = File.ReadAllText(@"C:\step\Avtoria\Avtoria\insertTable\insert_tabl_Avto_driver.sql");
                command.ExecuteNonQuery();
                Console.WriteLine("Таблицу TablBookAuthor.sql - заполненно");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибочка вышла : " + ex.Message);
            }


        }
    }

    
}
