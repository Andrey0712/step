using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Film_library
{
    [Table("tblFilm")]
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Director { get; set; }
        [Required, StringLength(255)]
        public string Genre { get; set; }
        [StringLength(500)]
        public string Actors { get; set; }
        public int Rating { get; set; }
        public virtual ICollection<Filter> Filters { get; set; }
    }
}
