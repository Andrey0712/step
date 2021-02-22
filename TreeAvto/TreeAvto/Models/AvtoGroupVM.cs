using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAvto.Models
{
    public class AvtoGroupVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        public int? ParentId { get; set; }

        public List<AvtoGroupVM> Children { get; set; }
    }
}
