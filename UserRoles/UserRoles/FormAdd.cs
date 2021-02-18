using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UserRoles.Model;
using UserRoles.Servis;
using UserRoles.Tabl_Context;

namespace UserRoles
{
    public partial class FormAdd : Form
    {
        MyContext context = new MyContext();
        public string fileSelected = string.Empty;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            foreach (var role in context.Roles)
            {
                CustomComboBoxItem item = new CustomComboBoxItem
                {
                    Id = role.Id,
                    Name = role.Name
                };
                comboBox2.Items.Add(item);
            }

            foreach (var user in context.Users)
            {
                CustomComboBoxItem item = new CustomComboBoxItem
                {
                    Id = user.Id,
                    Name = user.Name
                };
                comboBox1.Items.Add(item);
            }
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {

            context.Users.Add(
            new User
            {
                Name = textNameUser.Text,
                Email = textEmail.Text,
                PhoneNamber = textPhoneNamber.Text,
                Image = fileSelected
            });
            context.SaveChanges();

        }

        private void buttonSaveRole_Click(object sender, EventArgs e)
        {
            context.Roles.Add(
            new Role
            {
                Name = textRoleName.Text,
                ConcurrencyStamp = textRoleConcurrencyStamp.Text,

            });
            context.SaveChanges();
        }

        private void buttonUserRole_Click(object sender, EventArgs e)
        {
            var user = comboBox1.SelectedItem as CustomComboBoxItem;
            var role = comboBox2.SelectedItem as CustomComboBoxItem;

            context.UserRoles.Add(
                new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id
                });
            context.SaveChanges();

        }

        private void pbFotoUser_Click(object sender, EventArgs e)
        {
            AddFoto();


        }

        public void AddFoto()
        {

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

                pbFotoUser.Image = Image.FromFile(dir);

            }
        }
    }
}