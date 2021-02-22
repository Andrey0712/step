using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeAvto
{
    public static class Seeder
    {
        public static void SeedDatabase(MyContext context)
        {
            
            SeedAvto(context);
        }

        #region Сідимо категорії
        private static void SeedAvto(MyContext context)
        {
            if (context.Avtos.Count() == 0)
            {
                string category = "Avto";
                AddParent(context, category, "Автомобили");
                AddChildToParent(context, category, "Cars", "Легковые автомобили");
                AddChildToParent(context, category, "Motorcycles, mopeds", "Мотоциклы, мопеды");
                AddChildToParent(context, category, "Trucks", "Грузовые автомобили");

                category = "Cars";
                AddChildToParent(context, category, "Sedan", "Седан");
                AddChildToParent(context, category, "SUV", "Внедорожник");
                category = "Motorcycles, mopeds";
                AddChildToParent(context, category, "Motorcycle", "Мотоциклы");
                AddChildToParent(context, category, "Moped", "Мопеды");
                category = "Moped";
                AddChildToParent(context, category, "Electro scooter", "Улектро мопеды");
                AddChildToParent(context, category, "Scooter", "Скутер");


                category = "Boats";
                AddParent(context, category, "Лодки");
                AddChildToParent(context, category, "Motor boats", "Моторные лодки");
                AddChildToParent(context, category, "Inflatable boats", "Надувные лодки");
            }
        }
        private static void AddParent(MyContext context, string category, string name)
        {
            context.Avtos.Add(new Avto
            {
                Name = name,
                ParentId = null,
                Category = category
            });
            context.SaveChanges();
        }

        private static void AddChildToParent(MyContext context, string parentCategory, string category, string name)
        {
            var parent = context.Avtos.SingleOrDefault(x => x.Category == parentCategory);
            context.Avtos.Add(new Avto
            {
                Name = name,
                ParentId = parent.Id,
                Category = category
            });
            context.SaveChanges();
        }



        #endregion
    }
}
