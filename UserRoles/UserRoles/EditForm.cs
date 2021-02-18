using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static string foto_for_dell;

        public EditForm(int id)
        {
            InitializeComponent();
            _id = id;
            _context = new MyContext();
            initDataEdit();
        }

        private void initDataEdit()
        {
            var query = _context.UserRoles
                .Include(u => u.User).Include(rol => rol.Role).AsQueryable();
            var user = query
                .SingleOrDefault(p => p.Role.Id == _id);


            textBoxNewNameUser.Text = user.User.Name;

            foreach (var item in _context.Roles)
            {
                cbUsers.Items.Add(item);

                if (item.Id == user.RoleId)
                    cbUsers.SelectedItem = item;

            }

           


            string imageDir = "images";
            string dirImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                imageDir);
            if (!Directory.Exists(dirImagePath))
            {
                Directory.CreateDirectory(dirImagePath);
            }

            if (!string.IsNullOrEmpty(user.User.Image))
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", user.User.Image);
                pbChangeFoto.Image = Image.FromFile(dir);
                foto_for_dell = dir;//запаминаем фотку
            }


        }
         public string fileSelected = string.Empty;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var query = _context.UserRoles.Include(u => u.User).Include(rol => rol.Role).AsQueryable();
            var user = query
                .SingleOrDefault(p => p.Role.Id == _id);
            user.Role.Name = (cbUsers.SelectedItem as Role).Name;
            user.User.Name = textBoxNewNameUser.Text;
            user.User.Image = fileSelected;
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;

        }

        
        private void pbChangeFoto_Click(object sender, EventArgs e)
        {
            //FormAdd.AddFoto();
            File.Delete(foto_for_dell);

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var extention = Path.GetExtension(dlg.FileName);
                var imageName = Path.GetRandomFileName() + extention;
                fileSelected = imageName;
                string dir = Directory.GetCurrentDirectory();
                string imageDir = "images";
                string dirImagePath = Path.Combine(dir, imageDir);
                if (!Directory.Exists(dirImagePath))
                {
                    Directory.CreateDirectory(imageDir);
                }
                var fileSave = Path.Combine(dir, "images", imageName);
                File.Copy(dlg.FileName, fileSave);

                pbChangeFoto.Image = Image.FromFile(dir);
            }
        }
    }
}
