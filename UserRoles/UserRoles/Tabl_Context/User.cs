using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserRoles.Tabl_Context
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
        
        public string PhoneNamber { get; set; }

        public string Image { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
