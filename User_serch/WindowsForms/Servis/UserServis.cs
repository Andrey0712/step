using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using User_tel;
using WindowsForms.Model;

namespace WindowsForms.Servis
{
    public class UserServis
    {
        public static UserViewGrid Search(MyContext context, SearchUser search)
        {
            UserViewGrid model = new UserViewGrid();
            //отримуємо усі записи в оперативку
            //var query = context.Doctors.AsEnumerable();//.AsQueryable();
            //ми формуємо sql запит до БД - нічого з БД не отримуємо в цьому рядку
            var query = context.Users.AsQueryable();
            //Якщо DepartmentId !=null

            //if (search.DepartmentId.HasValue)
            //{
            //    query = query.Where(x => x.DepartmentId == search.DepartmentId.Value);
            //}

            //Якщо у search.Name != null
            if (!string.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }
            if (!string.IsNullOrEmpty(search.Telephone))
            {
                query = query.Where(x => x.Telephone.Contains(search.Telephone));
            }
            int amount = search.CountShowOnePage;
            int page = search.Page;
            model.CountRow = query.Count();
            model.Users = query
                .OrderBy(x=>x.Id)
                .Skip((page-1)* amount)
                .Take(amount)
                .Select(x => new UserItemView
                {
                    Id = x.Id,
                    Name = x.Name ,
                    Telephone = x.Telephone,
                    Gender = x.Gender
                }).ToList();
            return model;
        }
    }
}

