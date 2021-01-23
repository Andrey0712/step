
using Bogus;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Bogus.DataSets.Name;

namespace User_tel
{
    class Program
    {


        static void Main(string[] args)
        {

            MyContext context = new MyContext();
            //AddUsers.AddUser(context);

            //        void Serch()
            //        {
            //            Console.WriteLine("0. Виход");
            //            Console.WriteLine("1. Поиск по id и имени");
            //            Console.WriteLine("2. Поиск по Полу");
            //            Console.WriteLine("Сделайте Ваш выбор ");
            //            int act = int.Parse(Console.ReadLine());
            //            switch (act)
            //            {
            //                case 1:
            //                    {
            //                        string temp = string.Empty;
            //                        var query = context.Users.AsQueryable();
            //                        Console.WriteLine("Введите Имя ");
            //                        temp = Console.ReadLine();
            //                        if (!string.IsNullOrEmpty(temp))
            //                            query = query.Where(x => x.Name.Contains(temp));

            //                        Console.WriteLine("Введите id");
            //                        string temp1 = (Console.ReadLine());
            //                        if (!string.IsNullOrEmpty(temp1))
            //                        {
            //                            int id = int.Parse(temp1);
            //                            query = query.Where(x => x.Id == id);
            //                        }
            //                        foreach (var item in query.ToList()) 
            //                        {
            //                            Console.WriteLine($"{item.Id} {item.Name} {item.Telephone}");
            //                        }

            //                        break;
            //                    }
            //                case 2:
            //                    {
            //                        Console.WriteLine("Введите пол ");
            //                        byte gender = byte.Parse(Console.ReadLine());
            //                        User user = context.Users.FirstOrDefault(p => p.Gender == gender);

            //                        Console.WriteLine(user.Name);

            //                        break;
            //                    }

            //            }
            //        }




            //        //    u.Name = "Галушко Галина Генадиевна";
            //        //    u.Telephone = "0633333333";
            //        //    u.Weight = 45;
            //        //    u.Age = 30;
            //        //    u.Foot_size = 37;
            //        //    u.Gender = 0;

            //            //Console.WriteLine("Add id = {0}", faker.Id);
            //            int action = 0;

            //            do
            //            {
            //                Console.WriteLine("0. Виход");
            //                Console.WriteLine("1. Показть всех");
            //                Console.WriteLine("2. Добавить юзера");
            //                Console.WriteLine("3. Удалить юзера");
            //                Console.WriteLine("4. Редактировать юзера");
            //                Console.WriteLine("5. Поиск юзера ");
            //                Console.WriteLine("Сделайте Ваш выбор ");
            //            action = int.Parse(Console.ReadLine());
            //                switch (action)
            //                {
            //                    case 1:
            //                        {
            //                            foreach (var item in context.Users)
            //                            {
            //                                Console.WriteLine($"{item.Id} {item.Name}");
            //                            }
            //                            break;
            //                        }
            //                    case 2:
            //                        {
            //                            User user = new User();
            //                            Console.WriteLine("Введите ФИО ");
            //                            user.Name = Console.ReadLine();
            //                            Console.WriteLine("Введите номер телефона ");
            //                            user.Telephone = Console.ReadLine();
            //                            Console.WriteLine("Введите вес");
            //                            user.Weight = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите возраст");
            //                            user.Age = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите размер ноги");
            //                            user.Foot_size = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите пол юзера ");
            //                            user.Gender = (byte)int.Parse(Console.ReadLine());
            //                            context.Users.Add(user);
            //                            context.SaveChanges();
            //                            break;
            //                        }
            //                    case 3:
            //                        {

            //                            Console.WriteLine("Введите id");
            //                            int id = int.Parse(Console.ReadLine());
            //                            User user = context.Users
            //                                .SingleOrDefault(x => x.Id == id);
            //                            context.Users.Remove(user);
            //                            context.SaveChanges();
            //                            break;
            //                        }
            //                    case 4:
            //                        {

            //                            Console.WriteLine("Введите id");
            //                            int id = int.Parse(Console.ReadLine());
            //                            User user = context.Users
            //                                .SingleOrDefault(x => x.Id == id);
            //                            Console.WriteLine("Введите ФИО ");
            //                            user.Name = Console.ReadLine();
            //                            Console.WriteLine("Введите номер телефона ");
            //                            user.Telephone = Console.ReadLine();
            //                            Console.WriteLine("Введите вес");
            //                            user.Weight = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите возраст");
            //                            user.Age = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите размер ноги");
            //                            user.Foot_size = int.Parse(Console.ReadLine());
            //                            Console.WriteLine("Введите пол юзера ");
            //                            user.Gender = (byte)int.Parse(Console.ReadLine());
            //                            context.SaveChanges();
            //                            break;
            //                        }
            //                case 5:
            //                    {

            //                        Serch();
            //                        break;
            //                    }
            //            }
            //            } while (action != 0);
        }

    }
}
