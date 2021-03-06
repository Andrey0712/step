﻿using Film_library.Helpers;
using Film_library.Models;
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
            this.AutoScroll = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

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
           
             //список фільтрів
            var filters = GetFilterNameModels();
            FillCheckedList(filters);

        }

        
        public IEnumerable<FilterNameModel> GetFilterNameModels()
        {
            List<FilterNameModel> filterNameModels = new List<FilterNameModel>();
            //  Витягуємо елементи FilterName з БД
            var filterNames = from x in this._context.FilterNames.AsQueryable() select x;
            //  Витягуємо елементи FilterNameValue з БД
            var filterNameValue = from x in this._context.FilterNameGroups.AsQueryable() select x;

            var joinedCollection = (from name in filterNames    //  Вибірка усіх елементів FilterName З колекції
                                                                //  Join елементів по Id N-ного елемента і FilterNameId проміжної таблички
                                    join nameValue in filterNameValue on name.Id equals
                                    //  Запис данних у згруповану колекцію oneElementJoinedColl
                                    nameValue.FilterNameId into oneElementJoinedColl
                                    //  Проходження по новій колекції і формування анонімних обєктів
                                    from v in oneElementJoinedColl
                                    select new
                                    {
                                        FilterName = name.Name,
                                        FilterNameId = name.Id,
                                        FilterValue = v.FilterValueOf.Name,
                                        FilterValueId = v.FilterValueId
                                        // Приведення до типу AsEnumerable
                                    }).AsEnumerable();

            //  Вибірка елементів з колекції joinedCollection
            var groupsFilters = from x in joinedCollection
                                    //  Групування данних за ідентифікатором та назвою фільтра і переміщення нової
                                    //  колекції IGrouping до змінної newIGroupingCollection
                                group x by new { x.FilterNameId, x.FilterName } into newIGroupingCollection
                                //  Сортування нової колекції за іменем за спаданням
                                orderby newIGroupingCollection.Key.FilterName descending
                                //  Повернення колекції(груп)
                                select newIGroupingCollection;

            foreach (var item in groupsFilters)
            {
                //  Створення нової моделі де зберігаються дані про фільтр
                //  та його формуються його дочірні елементи
                FilterNameModel model = new FilterNameModel
                {
                    Id = item.Key.FilterNameId,
                    Name = item.Key.FilterName,
                    Children = item.Select(x => new FilterValueModel
                    {
                        Name = x.FilterValue,
                        Id = x.FilterValueId
                    }).ToList()
                };
                //  Додавання до колекції фільтрів нову модель
                filterNameModels.Add(model);
            }



            return filterNameModels;
        }

        private void FillCheckedList(IEnumerable<FilterNameModel> models)
        {
            GroupBox gbFilter;
            CheckedListBox listBox;
            int dy = 10;
            foreach (var item in models)
            {
                gbFilter = new System.Windows.Forms.GroupBox();
                listBox = new System.Windows.Forms.CheckedListBox();
                gbFilter.SuspendLayout();
                // 
                // gbFilter
                // 
                gbFilter.Controls.Add(listBox);
                gbFilter.Location = new System.Drawing.Point(10, dy);
                gbFilter.Name = $"gbFilter{item.Id}";
                gbFilter.Size = new System.Drawing.Size(150, 100);
                gbFilter.TabIndex = 0;
                gbFilter.TabStop = false;
                gbFilter.Text = item.Name;
                gbFilter.ForeColor = Color.Red;
                gbFilter.Tag = item;
                gbFilter.Click += new EventHandler(GbFilter_Click);
                // 
                // listBox
                // 
                listBox.FormattingEnabled = true;
                listBox.Location = new System.Drawing.Point(0, 30);
                listBox.Name = $"listBox{item.Id}";
                listBox.Width = 100;
                listBox.TabIndex = 0;

                foreach (var child in item.Children)
                {
                    listBox.Items.Add(child);
                }

                gbFilter.Size = new Size(listBox.Size.Width, listBox.Size.Height + 30);
                dy += gbFilter.Size.Height + 10;
                this.Controls.Add(gbFilter);

            }
        }

        private void GbFilter_Click(object sender, EventArgs e)
        {
            var groupBox = (sender as GroupBox);
            var FilterName = groupBox.Tag as FilterNameModel;
            var checkedList = groupBox.Controls.OfType<CheckedListBox>().FirstOrDefault();

            if (FilterName.IsCollapsed)
            {
                FilterName.IsCollapsed = false;
            }
            else
            {
                FilterName.IsCollapsed = true;

            }

           

            checkedList.Visible = FilterName.IsCollapsed;
            var Height = FilterName.IsCollapsed == true ? checkedList.Height + 30 : 30;
            groupBox.Height = Height;



            ShowAllGroups(this.Controls.OfType<GroupBox>());

        }

        private void ShowAllGroups(IEnumerable<GroupBox> groupBoxes)
        {
            int dy = 13;
            foreach (var box in groupBoxes)
            {
                box.Location = new Point(box.Location.X, dy);
                dy += box.Size.Height + 10;
            }
        }

        


        private void butAddFilm_Click(object sender, EventArgs e)
        {
            AddFilmForm dlg = new AddFilmForm();
            dlg.ShowDialog();
        }

        private void btnFiltrForm_Click(object sender, EventArgs e)
        {
            
            FilterForm dlg = new FilterForm();
            dlg.ShowDialog();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            //Збираємо значення фільтрів
            List<int> values = new List<int>();
            var listGB = this.Controls.OfType<GroupBox>();
            foreach (var groupBox in listGB)
            {
                var checkedItem = groupBox.Controls.OfType<CheckedListBox>().FirstOrDefault().CheckedItems;
                foreach (var listItem in checkedItem)
                {
                    //Збираємо значення id чекнутых фільтрів
                    var data = listItem as FilterValueModel;
                    values.Add(data.Id);
                    //MessageBox.Show($"{ data.Name}");
                }
            }
            //var filters = GetFilterNameModels();
            var filtersList = GetFilterNameModels();
            int[] filterValueSearchList = values.ToArray();

            var query = _context
                    .Films
                    .AsQueryable();

            foreach (var fName in filtersList)
            {
                int countFilter = 0; //Кількість співпадінь у даній групі фільтрів
                var predicate = PredicateBuilder.False<Film>();
                foreach (var fValue in fName.Children)
                {
                    for (int i = 0; i < filterValueSearchList.Length; i++)
                    {
                        var idV = fValue.Id; //id - значення фільтра
                        if (filterValueSearchList[i] == idV) //маємо співпадіння
                        {
                            predicate = predicate
                                .Or(p => p.Filters
                                    .Any(f => f.FilterValueId == idV));
                            countFilter++;
                        }
                    }
                }
                if (countFilter != 0)
                    query = query.Where(predicate);
            }

            var listProduct = query.ToList();
            dataGridView1.Rows.Clear();
            foreach (var p in listProduct)
            {
                object[] row =
                {
                    p.Id,
                    p.Name,
                    p.Director,
                    p.Genre,
                    p.Rating
                };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
