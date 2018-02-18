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
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = Record.accessories;
                gridAccessories.DataSource = bs1;
                gridAccessories.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridAccessories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridAccessories.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // If Cateogries Tab is selected
            if(tabControl2.SelectedIndex.Equals(4))
            {
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = Record.categories;
                gridCategories.DataSource = bs2;
                gridCategories.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            Record.UpdateCategories(ct);
            txtCategoryname.Text = "";
            BindingSource bs = new BindingSource();
            Record rd = new Record();
            bs.DataSource = Record.categories;
            gridCategories.DataSource = bs;
            gridCategories.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAccessory_Click(object sender, EventArgs e)
        {
            if (txtAccTitle.Text.Equals(""))
            {
                MessageBox.Show("Enter Accessory Name");
                return;
            }
            if (drpAccCategory.Text.Equals(""))
            {
                MessageBox.Show("No Cateogry Selected");
                return;
            }
            if (numQuantity.Value.Equals(0))
            {
                MessageBox.Show("Quantity is 0");
                return;
            }
            string AccessoryName = txtAccTitle.Text;
            string category = drpAccCategory.Text;
            int quantity = Int32.Parse(numQuantity.Text);
            Accessory acc = new Accessory(AccessoryName, quantity, category);
            Record.UpdateStock(acc);
            txtAccTitle.Text = "";
            // Adding to the Data Grid View
            BindingSource src = new BindingSource();
            src.DataSource = Record.accessories;
            gridAccessories.DataSource = src;
            gridAccessories.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridAccessories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridAccessories.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
