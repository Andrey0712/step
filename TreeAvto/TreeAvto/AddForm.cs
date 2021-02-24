using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnChild_Click(object sender, EventArgs e)
        {
           string parentCategory = tbNameParentCategory.Text;
            var parent = context.Avtos.SingleOrDefault(x => x.Category == parentCategory);
                       
            context.Avtos.Add(new Avto
            {
                Name = tbNameParent.Text,
                ParentId = parent.Id,
                Category = tbCategoryParent.Text
            });
            context.SaveChanges();
            this.Close();
            
            
        }
    }
}
