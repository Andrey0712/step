using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserRoles.Tabl_Context
{
    public static class Seeder
    {
        public static void SeedAll(MyContext context)
        {
            SeedUser(context);
            SeedRole(context);
            SeedUserRole(context);

        }
        private static void SeedUser(MyContext context)
        {
            if (context.Users.Count() == 0)
            {
                context.Users
                    .Add(new User
                    {
                        Name = "Зуева Галя",
                        Email="zueva@rambler.ru",
                        PhoneNamber="0631117722 "
                    });
                context.Users
                    .Add(new User 
                    {
                        Name = "Ескобар Пабло",
                        Email = "NarkoTrafik@gmail.com"
                    });
                
                context.SaveChanges();
            }
        }

        private static void SeedRole(MyContext context)
        {
            if (context.Roles.Count() == 0)
            {
                context.Roles
                    .Add(new Role
                    {
                        Name = "Домохазяйка",
                        ConcurrencyStamp = " Женщина, не работающая по найму и ведущая хозяйство своей семьи, " +
                        "находящаяся на материальном содержании у мужа."
                        
                    });
                context.Roles
                     .Add(new Role
                     {
                         Name = "Грузоперевозки",
                         ConcurrencyStamp = " Процесс, вследствие которого совершается перемещение из одного места в другое" +
                         " каких-либо объектов с помощью транспорта."

                     });
                context.Roles
                     .Add(new Role
                     {
                         Name = "Сельское хозяйство",
                         ConcurrencyStamp = "Деятельность, направленная на обеспечение населения продовольствием" +
                         " и получение сырья для ряда отраслей."

                     });
                context.SaveChanges();
            }
        }

        private static void SeedUserRole(MyContext context)
        {
            if (context.UserRoles.Count() == 0)
            {
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 1,
                        RoleId = 1,
                    });
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 1,
                        RoleId = 3,
                    });
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 2,
                        RoleId = 2,
                    });
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 2,
                        RoleId = 3,
                    });
                
                context.SaveChanges();
            }
        }
        }
}
