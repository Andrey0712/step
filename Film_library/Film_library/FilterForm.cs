using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Film_library
{
    public partial class FilterForm : Form
    {
        private readonly MyContext _context;
        public FilterForm(MyContext context)
        {
            InitializeComponent();
            _context = context;
            //var filters = GetListFilters();
        }
    }
}
