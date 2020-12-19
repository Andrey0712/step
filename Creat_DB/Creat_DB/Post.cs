using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Creat_DB
{
    [Table("tblPost")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(10)]
        public string Title { get; set; }
        [Required, StringLength(100)]
        public string ShortDescription { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required, StringLength(50)]
        public string Meta { get; set; }
        [Required, StringLength(50)]
        public string UrlSlug { get; set; }
        [Required, StringLength(50)]
        public byte Published { get; set; }
        [Required, StringLength(50)]
        public byte PostedOn { get; set; }
        [Required, StringLength(50)]
        public byte Modified { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
