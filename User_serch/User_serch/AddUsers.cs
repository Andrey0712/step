using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bogus.DataSets.Name;

namespace User_tel
{
    public class AddUsers
    {
        public static void AddUser(MyContext context)
        {

            if (context.Users.Count() <0)
            {
                var faker = new Faker<User>("uk");
                Random r = new Random();

                int amount = 80;
                for (int i = 0; i < amount; i++)
                {
                    int GenderUser = r.Next(1, 3);

                    if (GenderUser == 1)
                    {
                        faker.RuleFor(c => c.Name, (f, c) => f.Name.FullName(Gender.Female));
                        faker.RuleFor(c => c.Telephone, (f, c) => f.Phone.PhoneNumber());
                        faker.RuleFor(c => c.Gender, (f, c) => "Жінка");
                    }
                    else
                    {
                        faker.RuleFor(c => c.Name, (f, c) => f.Name.FullName(Gender.Male));
                        faker.RuleFor(c => c.Telephone, (f, c) => f.Phone.PhoneNumber());
                        faker.RuleFor(c => c.Gender, (f, c) => "Чоловік");
                    }
                    context.Users.Add(faker);


                }
                context.SaveChanges();
            }


        }
    }
}
