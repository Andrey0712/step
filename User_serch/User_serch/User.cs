using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace User_tel
{
    [Table("tblUser1")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Telephone { get; set; }

        public string Gender { get; set; }

    }
}
