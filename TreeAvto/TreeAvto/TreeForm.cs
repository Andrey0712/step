using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeAvto.Models;

namespace TreeAvto
{
    public partial class TreeForm : Form
    {
        private readonly MyContext _context;
        //public TreeForm(MyContext context)
             public TreeForm()
        {
            InitializeComponent();
            _context = new MyContext();
            Seeder.SeedDatabase(_context);
            
            
        }

        

        private void TreeForm_Load(object sender, EventArgs e)
        {
            var list = _context.Avtos
                .Where(x => x.ParentId == null)
                .Select(x => new AvtoVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    Category = x.Category
                }).ToList();
            foreach (var item in list)
            {
                AddParent(item);
            }
            treeViewAvto.Focus();
        }
        private void AddParent(AvtoVM avto)
        {
            TreeNode node = new TreeNode();
            node.Text = avto.Name;
            node.Name = avto.Id.ToString();
            node.Tag = avto;
            node.Nodes.Add("");
            treeViewAvto.Nodes.Add(node);

        }
        private void AddChild(TreeNode parent, AvtoVM avto)
        {
            
            TreeNode node = new TreeNode();
            node.Text = avto.Name;
            node.Name = avto.Id.ToString();
            node.Tag = avto;
            node.Nodes.Add("");
            parent.Nodes.Add(node);
        }
     

        private void treeViewAvto_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                var parent = e.Node;
                var parentId = (parent.Tag as AvtoVM).Id;
                parent.Nodes.Clear();
                var list = _context.Avtos
                .Where(x => x.ParentId == parentId)
                .Select(x => new AvtoVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    Category = x.Category
                }).ToList();

                foreach (var item in list)
                {
                    AddChild(parent, item);
                }
                //MessageBox.Show(parentId.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }
    }
}
