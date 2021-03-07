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
    public partial class FilterForm : Form
    {
        
        MyContext context = new MyContext();
       
        public FilterForm()
            
        {
            InitializeComponent();

            foreach (var filterName in context.FilterNames)
            {
                CustomComboBoxItem item = new CustomComboBoxItem
                {
                    Id = filterName.Id,
                    Name = filterName.Name
                };
                cbFilterCategory.Items.Add(item);
            }
           
        }

        private void btnSaveFiltr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameFiltr.Text) && tbFiltrVal1.Text != null)
            {
                string[] filterNames = {tbNameFiltr.Text};
            foreach (var type in filterNames)
            {
                if (context.FilterNames.SingleOrDefault(f => f.Name == type) == null)
                {
                    context.FilterNames.Add(
                        new FilterName
                        {
                            Name = type
                        });
                    context.SaveChanges();
                }
            }


            List<string[]> filterValues = new List<string[]>
            {                new string[] { tbFiltrVal1.Text } };

            foreach (var items in filterValues)
            {
                foreach (var value in items)
                {
                    if (context.FilterValues
                        .SingleOrDefault(f => f.Name == value) == null)
                    {
                        context.FilterValues.Add(
                            new FilterValue
                            {
                                Name = value
                            });
                        context.SaveChanges();
                    }
                }
            }
            for (int i = 0; i < filterNames.Length; i++)
            {
                foreach (var value in filterValues[i])
                {
                    var nId = context.FilterNames
                        .SingleOrDefault(ben => ben.Name == filterNames[i]).Id;
                    var vId = context.FilterValues
                        .SingleOrDefault(f => f.Name == value).Id;
                    if (context.FilterNameGroups
                        .SingleOrDefault(f => f.FilterValueId == vId &&
                        f.FilterNameId == nId) == null)
                    {
                        context.FilterNameGroups.Add(
                            new FilterNameGroup
                            {
                                FilterNameId = nId,
                                FilterValueId = vId
                            });
                        context.SaveChanges();
                    }
                }
            }
            }
            else
            {
                MessageBox.Show("Не все поля запонены!");
            }
            this.Close();



        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            
            context.FilterValues.Add(
               new FilterValue
               {
                  Name = tbFiltrVal3.Text
               });
            context.SaveChanges();
            var name_filtr_Id = context.FilterNames
                .SingleOrDefault(x => x.Name == cbFilterCategory.SelectedItem.ToString()).Id;
            var value_film_Id = context.FilterValues
                .SingleOrDefault(x => x.Name == tbFiltrVal3.Text).Id;
             

            if (context.FilterNameGroups
                .SingleOrDefault(x => x.FilterValueId == name_filtr_Id
                && x.FilterNameId == name_filtr_Id) == null)
            {
                context.FilterNameGroups.Add(
                    new FilterNameGroup
                    {
                        FilterNameId = name_filtr_Id,
                        FilterValueId = value_film_Id
                    });
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
