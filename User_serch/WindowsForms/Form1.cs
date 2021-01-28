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
            /// <summary>
            /// добавить пользователей если 0
            /// </summary>
            AddUsers.AddUser(context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SearchUsers();

            /// <summary>
            /// комбобокс кол-во выводов на стр
            /// </summary>
            cbCountShowPage.Items.AddRange(
                new List<CustomComboBoxItem>
                {
                    new CustomComboBoxItem{Id=1,Name="10"},
                    new CustomComboBoxItem{Id=2,Name="20"},
                    new CustomComboBoxItem{Id=3,Name="30"},
                }.ToArray()
                );
            cbCountShowPage.SelectedIndex = 0;
                    

        }
        /// <summary>
        /// кнопка поиск
        /// </summary>
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
            //    search = new SearchUser();
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

            /// <summary>
            /// кнопки динамические
            /// </summary>
            
            int totalPage = (int)Math.Ceiling((double)rez.CountRow / search.CountShowOnePage);
            int dx = 30;
            int positionX = 10;
            gbBTN.Controls.Clear();
            for (int i = 1; i <= totalPage; i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(positionX, 10);
                btn.Name = $"btnPage{i}";
                btn.Size = new System.Drawing.Size(30, 20);
                btn.Text = $"{i}";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.btnPage_Click);
                gbBTN.Controls.Add(btn);
                positionX += dx;
            }
        }

        /// <summary>
        /// кнопки << и >>
        /// </summary>

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

        /// <summary>
        /// кнопки динамические выбор стр
        /// </summary>
        private void btnPage_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            _page = int.Parse(s);
            SearchUsers(GetSearchInputValue());
        }
    }
}
