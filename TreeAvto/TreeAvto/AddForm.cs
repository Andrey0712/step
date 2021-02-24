using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeAvto
{
    public partial class AddForm : Form
    {
        MyContext context = new MyContext();
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSaveParent_Click(object sender, EventArgs e)
        {
            context.Avtos.Add(new Avto
            {
                Name = tbNameParent.Text,
                ParentId = null,
                Category = tbCategoryParent.Text
            });
            context.SaveChanges();
            this.Close();
        }
    }
}
