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
        //List<string[]> filterValues = new List<string[]>();
        MyContext context = new MyContext();
        //List<string> fValues = new List<string>();
        //private readonly MyContext _context;
         //int numb = int.Parse(Form1.);
        public FilterForm()
            //public FilterForm(int col)
        {
            InitializeComponent();
            //int positionY = 10;
            //int dx = 25;
            //gbFilterVal.Controls.Clear();
            //for (int i = 1; i <= col; i++)
            //{
            //    TextBox textBox = new TextBox();

            //    textBox.Location = new System.Drawing.Point(10, positionY);
            //    textBox.Name = $"tbFiltrVal{i}";
            //    textBox.Size = new System.Drawing.Size(100, 10);

            //    gbFilterVal.Controls.Add(textBox);

            //    filterValues.Add(textBox.Name.ToString());
                
            //    positionY += dx;


            //}
            //var filters = GetListFilters();
        }

        private void btnSaveFiltr_Click(object sender, EventArgs e)
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
            {                new string[] { tbFiltrVal1.Text, tbFiltrVal2.Text, tbFiltrVal3.Text, tbFiltrVal4.Text } };

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

            this.Close();



        }
    }
}
