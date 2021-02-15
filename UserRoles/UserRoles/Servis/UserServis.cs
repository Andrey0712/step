using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserRoles.Model;
using UserRoles.Tabl_Context;

namespace UserRoles.Servis
{
    public class UserServis
    {
        public static UserViewGrid Search(MyContext context, SearchUser search)
        {
            UserViewGrid model = new UserViewGrid();
            
            var query = context.UserRoles.Include(u => u.User).Include(rol => rol.Role).AsQueryable();
            
            if (!string.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.User.Name.Contains(search.Name));
            }
            
            
            model.Users = query.Select(x => new UserItemView
            {
                Id = x.User.Id,
                Name = x.User.Name,
                RoleName = x.Role.Name
            }
                ).ToList();
            return model;

            
            
        }
    }
}
