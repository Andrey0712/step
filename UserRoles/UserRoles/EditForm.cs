using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserRoles.Tabl_Context;

namespace UserRoles
{
    public partial class EditForm : Form
    {
        private readonly int _id;
        private readonly MyContext _context;
        
        public EditForm(int id)
        {
            InitializeComponent();
            _id = id;
            _context = new MyContext();
            initDataEdit();
        }

        private void initDataEdit()
        {
            var query = _context.UserRoles.Include(u => u.User).Include(rol => rol.Role).AsQueryable();
            var user = query
                .SingleOrDefault(p => p.Role.Id == _id);

           textBoxNewNameUser.Text = user.User.Name;

            foreach (var item in _context.Roles)
            {
                cbUsers.Items.Add(item);
                if (item.Id == user.Role.Id)
                    cbUsers.SelectedItem = item;
            }
            



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var query = _context.UserRoles.Include(u => u.User).Include(rol => rol.Role).AsQueryable();
            var user = query
                .SingleOrDefault(p => p.Role.Id == _id);
            user.Role.Name = (cbUsers.SelectedItem as Role).Name;
            user.User.Name = textBoxNewNameUser.Text;
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;

        }
    }
}
