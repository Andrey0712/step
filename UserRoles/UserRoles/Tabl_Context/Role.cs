﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserRoles.Tabl_Context
{
    [Table("tblRoles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(4000)]
        public string ConcurrencyStamp { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
