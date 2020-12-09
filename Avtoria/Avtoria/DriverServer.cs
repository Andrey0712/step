using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    public class DriverServer
    {
        private SqlConnection _conn;
        public DriverServer(string conStr)
        {
            _conn = new SqlConnection(conStr);
            _conn.Open();
        }



        public List<Driver> GetAll()
        {
            List<Driver> list = new List<Driver>();
            string query = "Select Id, Name, Address, PhoneNumber From Driver";
            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Driver driver = new Driver();
                    driver.Id = int.Parse(reader["Id"].ToString());
                    driver.Name = reader["Name"].ToString();
                    driver.Address = reader["Address"].ToString();
                    driver.PhoneNumber = reader["PhoneNumber"].ToString();
                    list.Add(driver);
                }
            }
            return list;
        }

        public void Add(Driver driver)
        {


            string query = "INSERT INTO " +
                    "[dbo].[Driver] " +
                    "(Name, Address, PhoneNumber) " +
                    $"VALUES(" +
                            $"N'{driver.Name}', " +
                            $"N'{driver.Address}', " +
                            $"N'{driver.PhoneNumber}');";
            SqlCommand command = new SqlCommand(query, _conn);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Успішно додано в БД");
            }
            else
            {
                Console.WriteLine("Виникли проблеми при додаванні");
            }
        }
        public void del(int id)
        {
            Console.WriteLine("Введите номер id");
            int n = int.Parse(Console.ReadLine());
            string query1 = $"DELETE FROM [dbo].[Driver]  WHERE Id={n}";

            SqlCommand command1 = new SqlCommand(query1, _conn);
            int result1 = command1.ExecuteNonQuery();
            if (result1 > 0)
            {
                Console.WriteLine("Успішно удалено из БД");
            }
            else
            {
                Console.WriteLine("Виникли проблеми при удалении");
            }
        }



        //public void Update(int id, Driver driver)
        //{

        //    string query2 = "  UPDATE [dbo].[Driver] " +
        //        $"SET Name = '{driver.Name}', Address = '{driver.Address}'," +
        //        $" PhoneNumber = '{driver.PhoneNumber}' " +
        //        $"WHERE Id = {id}; ";
        //    SqlCommand command = new SqlCommand(query2, _conn);
        //    command.ExecuteNonQuery();
        //    int res2 = command.ExecuteNonQuery();
        //    if (res2 > 0)
        //    {
        //        Console.WriteLine("Успішно редактованно в БД");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Виникли проблеми при редактуванні");
        //    }

        //}

        public void Update(int id, Driver driver)
        {

            string query2 = "  UPDATE [dbo].[Driver] "+$"" ;

            bool isBegin = true;
            if(!string.IsNullOrEmpty(driver.Name))
            {
                isBegin = false;
                query2 += $"SET Name = N'{driver.Name}'";
            }
            if (!string.IsNullOrEmpty(driver.Address))
            {
                if (isBegin) 
                { 
                    query2 += "SET ";
                    isBegin = false;

                }
                else
                {
                    query2 += ", ";
                }
                
                query2 += $"Address = N'{driver.Address}'";
            }
            if (!string.IsNullOrEmpty(driver.PhoneNumber))
            {
                if (isBegin)
                {
                    query2 += "SET ";
                    isBegin = false;

                }
                else
                {
                    query2 += ", ";
                }

                query2 += $"PhoneNumber = N'{driver.PhoneNumber}'";
            }
            query2+= $"WHERE Id = {id}; ";
            SqlCommand command = new SqlCommand(query2 , _conn);
            command.ExecuteNonQuery();
            int res2 = command.ExecuteNonQuery();
            if (res2 > 0)
            {
                Console.WriteLine("Успішно редактованно в БД");
            }
            else
            {
                Console.WriteLine("Виникли проблеми при редактуванні");
            }

        }

        
        private static int id;
        public void MenuDriver()
        {
             string strConnection = "  Data Source=PK;Initial Catalog=Avtoria;Integrated Security=True";
            DriverServer driverService = new DriverServer(strConnection);

            int action = 0;
            do
            {
                Console.WriteLine("0. Виход");
                Console.WriteLine("1. Показать всех");
                Console.WriteLine("2. Добавить");
                Console.WriteLine("3. Удалить");
                Console.WriteLine("4. Корекция");
                Console.WriteLine("5. Поиск");
                Console.Write("->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            var list = driverService.GetAll();
                            foreach (var item in list)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {
                            Driver driver = new Driver();
                            Console.Write("Введите имя: ");
                            driver.Name = Console.ReadLine();
                            Console.Write("Укажите адрес: ");
                            driver.Address = Console.ReadLine();
                            Console.Write("Укажите номер телефона: ");
                            driver.PhoneNumber = Console.ReadLine();
                            driverService.Add(driver);
                            break;
                        }
                    case 3:
                        {
                            driverService.del(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter id for update your database");
                            int res2 = int.Parse(Console.ReadLine());
                            Driver driver = new Driver();
                            Console.Write("Введите имя: ");
                            driver.Name = Console.ReadLine();
                            Console.Write("Укажите адрес: ");
                            driver.Address = Console.ReadLine();
                            Console.Write("Укажите номер телефона: ");
                            driver.PhoneNumber = Console.ReadLine();
                            driverService.Update(res2, driver);
                            break;
                        }
                    case 5:
                        {
                            Driver ds = new Driver();
                            Console.Write("Введите имя: ");
                            ds.Name = Console.ReadLine();
                            Console.Write("Укажите адрес: ");
                            ds.Address = Console.ReadLine();
                            Console.Write("Укажите номер телефона: ");
                            ds.PhoneNumber = Console.ReadLine();
                            var list = driverService.Search(ds);
                            foreach (var item in list)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                }

            } while (action != 0);
        }

        public List<Driver> Search(Driver ds)
        {
            List<Driver> list = new List<Driver>();
            string query = "Select Id, Name, Address, PhoneNumber From Driver";

            bool isBegin = true;
            if(!string.IsNullOrEmpty(ds.Name))
            {
                isBegin = false;
                query += $" Where Name LIKE N'{ds.Name}%'";
            }
            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Driver driver = new Driver();
                    driver.Id = int.Parse(reader["Id"].ToString());
                    driver.Name = reader["Name"].ToString();
                    driver.Address = reader["Address"].ToString();
                    driver.PhoneNumber = reader["PhoneNumber"].ToString();
                    list.Add(driver);
                }
            }
            return list;
        }



    }
}
