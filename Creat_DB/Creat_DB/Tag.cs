using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Creat_DB
{
    [Table("tblTag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string UrlSlug { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
    }
}
