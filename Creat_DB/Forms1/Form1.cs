using Creat_DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.categories)
            {


                object[] row = {
                    $"{item.Name}",
                    $"{item.UrlSlug}",
                    $"{item.Description}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finish");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
