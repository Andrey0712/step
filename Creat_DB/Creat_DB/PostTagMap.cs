using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Creat_DB
{
    [Table("tblPostTagMap")]
    public class PostTagMap
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Post")]
        public int Post_Id { get; set; }
        public virtual Post Post { get; set; }

        [ForeignKey("Tag")]
        public int Tag_Id { get; set; }

        public virtual Tag Tag { get; set; }

    }
}
