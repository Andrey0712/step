using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_tel;
using WindowsForms.Model;
using WindowsForms.Servis;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        SearchUser search = new SearchUser();
        CustomComboBoxItem item = new CustomComboBoxItem();

        private int _page = 1;
        private readonly MyContext context;
        public Form1()
        {
            context = new MyContext();
            InitializeComponent();
            AddUsers.AddUser(context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SearchUsers();

            cbCountShowPage.Items.AddRange(
                new List<CustomComboBoxItem>
                {
                    new CustomComboBoxItem{Id=1,Name="10"},
                    new CustomComboBoxItem{Id=2,Name="20"},
                    new CustomComboBoxItem{Id=3,Name="30"},
                }.ToArray()
                );



        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
                        
            search.Name = textName.Text;
            search.Telephone = textTel.Text;

            //var item = cbDepatments.SelectedItem;
            //if (item != null)
            //{
            //    var dep = cbDepatments.SelectedItem as CustomComboBoxItem;
            //    search.DepartmentId = dep.Id;
            //}
            _page = 1;
            SearchUsers(GetSearchInputValue());

        }

        private SearchUser GetSearchInputValue()
        {
            search.Name = textName.Text;
            search.Telephone = textTel.Text;
            var countSelect = cbCountShowPage.SelectedItem as CustomComboBoxItem;
            search.CountShowOnePage = int.Parse(countSelect.Name);
            return search;
        }

        private void SearchUsers(SearchUser search = null)
        {
            FormTelSerch.Rows.Clear();
            //if (search == null)
            //    search = new SearchDoctor();
            search ??= new SearchUser();
            search.Page = _page;
            var rez = UserServis.Search(context, search);
            foreach (var item in rez.Users)
            {

                object[] row =
                  {
                    item.Id,
                    item.Name,
                    item.Telephone,
                    item.Gender
                    };
                FormTelSerch.Rows.Add(row);

            }
            int start = (_page - 1) * search.CountShowOnePage + 1;
            labelDiapason.Text = $"Діапазон : {start} - {start+ search.CountShowOnePage-1}";
            lblCount.Text = "Всього записів: " + rez.CountRow.ToString();
            
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            
            if (_page>1)
            _page -= 1;
            SearchUsers(GetSearchInputValue());
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            _page += 1;
            SearchUsers(GetSearchInputValue());
        }

        
    }
}
