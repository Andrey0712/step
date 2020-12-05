using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoria
{
    public class AvtoServis
    {
        private SqlConnection _conn;
        public AvtoServis(string conStr)
        {
            _conn = new SqlConnection(conStr);
            _conn.Open();
        }

        public List<Avto> GetAll_avto()
        {
            List<Avto> list1 = new List<Avto>();
            string query = "Select Id, Name, Namber From Avto";
            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Avto avto = new Avto();
                    avto.Id = int.Parse(reader["Id"].ToString());
                    avto.Name = reader["Name"].ToString();
                    avto.Namber = reader["Namber"].ToString();
                    
                    list1.Add(avto);
                }
            }
            return list1;
        }

        public void Add_avto(Avto avto)
        {


            string query = "INSERT INTO " +
                    "[dbo].[Avto] " +
                    "(Name, Namber) " +
                    $"VALUES(" +
                            $"N'{avto.Name}', " +
                            $"N'{avto.Namber}');";
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
        public void del_avto(int id)
        {
            Console.WriteLine("Введите номер id");
            
            string query1 = $"DELETE FROM [dbo].[Avto]  WHERE Id={id}";

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

        public void Update_avto(int id, Avto avto)
        {

            string query2 = "  UPDATE [dbo].[Avto] " + $"";

            bool isBegin = true;
            if (!string.IsNullOrEmpty(avto.Name))
            {
                isBegin = false;
                query2 += $"SET Name = N'{avto.Name}'";
            }
            if (!string.IsNullOrEmpty(avto.Namber))
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

                query2 += $"Namber = N'{avto.Namber}'";
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
        public void MenuAvto()
        {
            string strConnection = "  Data Source=PK;Initial Catalog=Avtoria;Integrated Security=True";
            AvtoServis avtoService = new AvtoServis(strConnection);

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
                            List<Avto> list1 = avtoService.GetAll_avto();
                            foreach (var item in list1)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {
                            
                            Avto avto = new Avto();
                            Console.Write("Введите марку авто: ");
                            avto.Name = Console.ReadLine();
                            Console.Write("Укажите номер: ");
                            avto.Namber = Console.ReadLine();
                            avtoService.Add_avto(avto);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Укажите номер ID: ");
                            int id = int.Parse(Console.ReadLine());
                            avtoService.del_avto(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter id for update your database");
                            int res2 = int.Parse(Console.ReadLine());
                            Avto avto = new Avto();
                            Console.Write("Введите имя: ");
                            avto.Name = Console.ReadLine();
                            Console.Write("Укажите номер: ");
                            avto.Namber = Console.ReadLine();
                            
                            avtoService.Update_avto(res2, avto);
                            break;
                        }
                }

            } while (action != 0);
        }
    
}
}
