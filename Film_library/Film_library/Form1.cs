using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_library
{
    public partial class Form1 : Form
    {
        private readonly MyContext _context;
        public Form1()
        {
            _context = new MyContext();
            Seeder.SeedDatabase(_context);
            InitializeComponent();
            loadFromData();
        }

        private void loadFromData()
        {
            dataGridView1.Rows.Clear();
            var query = _context.Films
               .AsQueryable();

            var list = query.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Director = x.Director,
                Genre = x.Genre,
                Rating = x.Rating
            })
                .AsQueryable().ToList();

            foreach (var item in list)
            {

                object[] row =

                {
             item.Id,
             item.Name,
             item.Director,
             item.Genre,
             item.Rating,
                };
                dataGridView1.Rows
                    .Add(row);

            }
        }

        private void butAddFilm_Click(object sender, EventArgs e)
        {
            AddFilmForm dlg = new AddFilmForm();
            dlg.ShowDialog();
        }

        private void btnFiltrForm_Click(object sender, EventArgs e)
        {
            FilterForm dlg = new FilterForm(_context);
            dlg.ShowDialog();
        }
    }
}
