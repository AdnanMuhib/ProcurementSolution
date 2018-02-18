using ProcurementSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSolution
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tabControl2.SelectedIndexChanged += new EventHandler(Tabs_SelectedIndexChanged);
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If new Accessory Stock Tab is Clicked then
            if(tabControl2.SelectedIndex.Equals(3))
            {
                BindingSource bs = new BindingSource();
                List<String> cats = new List<string>();
                foreach (var str in Record.categories)
                {
                    cats.Add(str.category_name);
                }
                bs.DataSource = cats;
                drpAccCategory.DataSource = bs;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryname.Text.Equals(""))
            {
                MessageBox.Show("Kindly Enter Category Name");
                return;
            }
            string cat = txtCategoryname.Text;
            Category ct = new Category(cat);
            ct.AddToList();
            txtCategoryname.Text = "";
            BindingSource bs = new BindingSource();
            Record rd = new Record();
            bs.DataSource = Record.categories;
            gridCategories.DataSource = bs;
            //MessageBox.Show("New Category Added Successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
