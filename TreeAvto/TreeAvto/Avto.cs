using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreeAvto
{
    [Table("tblAvto")]
    public class Avto
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        public string Category { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public virtual Avto Parent { get; set; }
    }
}
