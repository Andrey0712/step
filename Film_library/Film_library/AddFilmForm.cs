using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Film_library
{
    public partial class AddFilmForm : Form
    {
        MyContext context = new MyContext();
        public AddFilmForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.Films.Add(new Film
            {
                Name = tbName.Text,
                Director = tbDirector.Text,
                Genre = tbGanre.Text,
                Rating =int.Parse(tbRating.Text)
            });
            context.SaveChanges();
            this.Close();
        }

        private void btnAddFiltrToFilm_Click(object sender, EventArgs e)
        {
            AddFilmToFiltr dlg = new AddFilmToFiltr();
            dlg.ShowDialog();
            this.Close();
        }
    }
}
