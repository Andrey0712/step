using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    class Avto_driverServis
    {
        private SqlConnection _conn;
        public Avto_driverServis(string conStr)
        {
            _conn = new SqlConnection(conStr);
            _conn.Open();
        }

        public List<Avto_Driver> GetAll_avto_driver()
        {
            List<Avto_Driver> list2 = new List<Avto_Driver>();
            string query = "Select Id, AvtoId, DriverId From Avto_driver";
            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Avto_Driver a_d = new Avto_Driver();
                    a_d.Id = int.Parse(reader["Id"].ToString());
                    a_d.AvtoId = reader["AvtoId"].ToString();
                    a_d.DriverId = reader["DriverId"].ToString();

                    list2.Add(a_d);
                }
            }
            return list2;
        }

        public void Add_avto_driver(Avto_Driver a_d)
        {


            string query = "INSERT INTO " +
                    "[dbo].[Avto_driver] " +
                    "(AvtoId, DriverId) " +
                    $"VALUES(" +
                            $"N'{a_d.AvtoId}', " +
                            $"N'{a_d.DriverId}');";
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
        public void del_avto_driver(int id)
        {
            Console.WriteLine("Введите номер id");

            string query1 = $"DELETE FROM [dbo].[Avto_driver]  WHERE Id={id}";

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

        public void Update_avto_driver(int id, Avto_Driver a_d)
        {

            string query2 = "  UPDATE [dbo].[Avto_driver] " + $"";

            bool isBegin = true;
            if (!string.IsNullOrEmpty(a_d.AvtoId))
            {
                isBegin = false;
                query2 += $"SET AvtoId = N'{a_d.AvtoId}'";
            }
            if (!string.IsNullOrEmpty(a_d.DriverId))
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

                query2 += $"DriverId = N'{a_d.DriverId}'";
            }
            query2 += $"WHERE Id = {id}; ";
            SqlCommand command = new SqlCommand(query2, _conn);
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
        public void MenuAvto_Driver()
        {
            string strConnection = "  Data Source=PK;Initial Catalog=Avtoria;Integrated Security=True";
            Avto_driverServis a_d_Servis = new Avto_driverServis(strConnection);

            int action = 0;
            do
            {
                Console.WriteLine("0. Виход");
                Console.WriteLine("1. Показать всех");
                Console.WriteLine("2. Добавить");
                Console.WriteLine("3. Удалить");
                Console.WriteLine("4. Корекция");
                Console.Write("->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            List<Avto_Driver> list2 = a_d_Servis.GetAll_avto_driver();
                            foreach (var item in list2)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {

                            Avto_Driver ad = new Avto_Driver();
                            Console.Write("Введите ID авто: ");
                            ad.AvtoId = Console.ReadLine();
                            Console.Write("Укажите ID драйвера : ");
                            ad.DriverId = Console.ReadLine();
                            a_d_Servis.Add_avto_driver(ad);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Укажите номер ID: ");
                            int id = int.Parse(Console.ReadLine());
                            a_d_Servis.del_avto_driver(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter id for update your database");
                            int res2 = int.Parse(Console.ReadLine());
                            Avto_Driver ad = new Avto_Driver();
                            Console.Write("Введите ID авто: ");
                            ad.AvtoId = Console.ReadLine();
                            Console.Write("Укажите ID драйвера : ");
                            ad.DriverId = Console.ReadLine();
                            a_d_Servis.Update_avto_driver(res2, ad);
                            break;
                        }
                }

            } while (action != 0);
        }

    }
}
