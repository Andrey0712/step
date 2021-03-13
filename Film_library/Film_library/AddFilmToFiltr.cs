using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Film_library
{
    public partial class AddFilmToFiltr : Form
    {
        MyContext context = new MyContext();
        public AddFilmToFiltr()
        {
            InitializeComponent();
            foreach (var filmName in context.Films)
            {
                CustomComboBoxItem item = new CustomComboBoxItem
                {
                    Id = filmName.Id,
                    Name = filmName.Name
                };
                cbAddFilmToFiltr.Items.Add(item);

            }
            foreach (var filtrName in context.FilterNames)
            {
                CustomComboBoxItem item1 = new CustomComboBoxItem
                {
                    Id = filtrName.Id,
                    Name = filtrName.Name
                };
                cbAddNameToFiltr.Items.Add(item1);

            }
            foreach (var filtrVal in context.FilterValues)
            {
                CustomComboBoxItem item2 = new CustomComboBoxItem
                {
                    Id = filtrVal.Id,
                    Name = filtrVal.Name
                };
                cbAddValToFiltr.Items.Add(item2);

            }
        }

        

        private void btnSaveFiltr_Click(object sender, EventArgs e)
        {
            
            context.Filters.Add(new Filter
            {
                FilterNameId = (cbAddNameToFiltr.SelectedItem as CustomComboBoxItem).Id,
                FilterValueId = (cbAddValToFiltr.SelectedItem as CustomComboBoxItem).Id,
                FilmId = (cbAddFilmToFiltr.SelectedItem as CustomComboBoxItem).Id

            });
            context.SaveChanges();
            this.Close();
        }
    }
}
