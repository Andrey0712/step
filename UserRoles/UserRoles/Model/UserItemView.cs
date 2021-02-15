using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Model
{
    public class UserItemView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PhoneNamber { get; set; }

        public string RoleName { get; set; }
    }

    public class UserViewGrid
    {
        /// <summary>
        /// всего отображено
        /// </summary>
        public List<UserItemView> Users { get; set; }
        /// <summary>
        /// всего найдено
        /// </summary>
        public int CountRow { get; set; }
    }
}
