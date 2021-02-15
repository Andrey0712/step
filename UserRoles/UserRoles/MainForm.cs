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
using UserRoles.Servis;
using UserRoles.Tabl_Context;

namespace UserRoles
{
    public partial class MainForm : Form
    {
        SearchUser search = new SearchUser();
        
        MyContext context = new MyContext();
        public MainForm()
        {
            InitializeComponent();
            Seeder.SeedAll(context);

           

        }

          
        private void MainForm_Load(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void SearchUsers(SearchUser search = null)
        {
            
            dgvUser.Rows.Clear();

           
            search ??= new SearchUser();

            var rez = UserServis.Search(context, search);

            foreach (var item in rez.Users)
            {
                object[] row =
                {                  
                   
                    item.Id,
                    item.Name,
                    item.RoleName
                };
                                
                dgvUser.Rows.Add(row);
            }
        }

        

        private SearchUser GetSearchInputValue()
        {
            search.Name = textName.Text;
            
            return search;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search.Name = textName.Text;


            SearchUsers(GetSearchInputValue());
        }

        //удалене по текстовому полю
        private void btnDell_Click(object sender, EventArgs e)
        {
            User userDell = context.Users.SingleOrDefault(x => x.Name == textName.Text);
            if (userDell != null)
            {
                context.Users.Remove(userDell);
                context.SaveChanges();
            }
            else
                MessageBox.Show("Нет в базе такого юзера");

        }

        private void buttoтAdd_Click(object sender, EventArgs e)
        {
            new FormAdd().ShowDialog();
            //Close();
            
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                int id = int.Parse(dgvUser["ColId", dgvUser.CurrentRow.Index].Value.ToString());
                MessageBox.Show($"{ id}");
                EditForm dlg = new EditForm(id);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MainForm_Load(sender, e);
                }
            }
        }
    }
}
