namespace ProcurementSolution
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AccessoriesPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.IssueAccPage = new System.Windows.Forms.TabPage();
            this.AvailableAccPage = new System.Windows.Forms.TabPage();
            this.IssuedAccPage = new System.Windows.Forms.TabPage();
            this.AccAddStockPage = new System.Windows.Forms.TabPage();
            this.AccCategoryPage = new System.Windows.Forms.TabPage();
            this.EmployeesPage = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.NewEmpPage = new System.Windows.Forms.TabPage();
            this.AllEmpPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryname = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccTitle = new System.Windows.Forms.TextBox();
            this.drpAccCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAccessory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AccessoriesPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AccAddStockPage.SuspendLayout();
            this.AccCategoryPage.SuspendLayout();
            this.EmployeesPage.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AccessoriesPage);
            this.tabControl1.Controls.Add(this.EmployeesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // AccessoriesPage
            // 
            this.AccessoriesPage.Controls.Add(this.tabControl2);
            this.AccessoriesPage.Location = new System.Drawing.Point(4, 27);
            this.AccessoriesPage.Name = "AccessoriesPage";
            this.AccessoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccessoriesPage.Size = new System.Drawing.Size(657, 462);
            this.AccessoriesPage.TabIndex = 0;
            this.AccessoriesPage.Text = "Accessories";
            this.AccessoriesPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.IssueAccPage);
            this.tabControl2.Controls.Add(this.AvailableAccPage);
            this.tabControl2.Controls.Add(this.IssuedAccPage);
            this.tabControl2.Controls.Add(this.AccAddStockPage);
            this.tabControl2.Controls.Add(this.AccCategoryPage);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(651, 456);
            this.tabControl2.TabIndex = 0;
            // 
            // IssueAccPage
            // 
            this.IssueAccPage.Location = new System.Drawing.Point(4, 27);
            this.IssueAccPage.Name = "IssueAccPage";
            this.IssueAccPage.Padding = new System.Windows.Forms.Padding(3);
            this.IssueAccPage.Size = new System.Drawing.Size(643, 425);
            this.IssueAccPage.TabIndex = 0;
            this.IssueAccPage.Text = "Issue Accessory";
            this.IssueAccPage.UseVisualStyleBackColor = true;
            // 
            // AvailableAccPage
            // 
            this.AvailableAccPage.Location = new System.Drawing.Point(4, 27);
            this.AvailableAccPage.Name = "AvailableAccPage";
            this.AvailableAccPage.Padding = new System.Windows.Forms.Padding(3);
            this.AvailableAccPage.Size = new System.Drawing.Size(643, 425);
            this.AvailableAccPage.TabIndex = 1;
            this.AvailableAccPage.Text = "Available Accessories";
            this.AvailableAccPage.UseVisualStyleBackColor = true;
            // 
            // IssuedAccPage
            // 
            this.IssuedAccPage.Location = new System.Drawing.Point(4, 27);
            this.IssuedAccPage.Name = "IssuedAccPage";
            this.IssuedAccPage.Size = new System.Drawing.Size(643, 425);
            this.IssuedAccPage.TabIndex = 4;
            this.IssuedAccPage.Text = "Issued";
            this.IssuedAccPage.UseVisualStyleBackColor = true;
            // 
            // AccAddStockPage
            // 
            this.AccAddStockPage.Controls.Add(this.btnAddAccessory);
            this.AccAddStockPage.Controls.Add(this.label2);
            this.AccAddStockPage.Controls.Add(this.txtAccTitle);
            this.AccAddStockPage.Controls.Add(this.label3);
            this.AccAddStockPage.Controls.Add(this.numQuantity);
            this.AccAddStockPage.Controls.Add(this.drpAccCategory);
            this.AccAddStockPage.Controls.Add(this.label4);
            this.AccAddStockPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AccAddStockPage.Location = new System.Drawing.Point(4, 27);
            this.AccAddStockPage.Name = "AccAddStockPage";
            this.AccAddStockPage.Size = new System.Drawing.Size(643, 425);
            this.AccAddStockPage.TabIndex = 3;
            this.AccAddStockPage.Text = "New Accessory Stock";
            this.AccAddStockPage.UseVisualStyleBackColor = true;
            // 
            // AccCategoryPage
            // 
            this.AccCategoryPage.Controls.Add(this.gridCategories);
            this.AccCategoryPage.Controls.Add(this.panel1);
            this.AccCategoryPage.Location = new System.Drawing.Point(4, 27);
            this.AccCategoryPage.Name = "AccCategoryPage";
            this.AccCategoryPage.Size = new System.Drawing.Size(643, 425);
            this.AccCategoryPage.TabIndex = 2;
            this.AccCategoryPage.Text = "Accessory Category";
            this.AccCategoryPage.UseVisualStyleBackColor = true;
            // 
            // EmployeesPage
            // 
            this.EmployeesPage.Controls.Add(this.tabControl3);
            this.EmployeesPage.Location = new System.Drawing.Point(4, 27);
            this.EmployeesPage.Name = "EmployeesPage";
            this.EmployeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesPage.Size = new System.Drawing.Size(657, 462);
            this.EmployeesPage.TabIndex = 1;
            this.EmployeesPage.Text = "Employees";
            this.EmployeesPage.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.NewEmpPage);
            this.tabControl3.Controls.Add(this.AllEmpPage);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(651, 456);
            this.tabControl3.TabIndex = 0;
            // 
            // NewEmpPage
            // 
            this.NewEmpPage.Location = new System.Drawing.Point(4, 27);
            this.NewEmpPage.Name = "NewEmpPage";
            this.NewEmpPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewEmpPage.Size = new System.Drawing.Size(643, 425);
            this.NewEmpPage.TabIndex = 0;
            this.NewEmpPage.Text = "New Employee";
            this.NewEmpPage.UseVisualStyleBackColor = true;
            // 
            // AllEmpPage
            // 
            this.AllEmpPage.Location = new System.Drawing.Point(4, 27);
            this.AllEmpPage.Name = "AllEmpPage";
            this.AllEmpPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllEmpPage.Size = new System.Drawing.Size(643, 425);
            this.AllEmpPage.TabIndex = 1;
            this.AllEmpPage.Text = "All Employees";
            this.AllEmpPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category Name";
            // 
            // txtCategoryname
            // 
            this.txtCategoryname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategoryname.Location = new System.Drawing.Point(195, 42);
            this.txtCategoryname.Name = "txtCategoryname";
            this.txtCategoryname.Size = new System.Drawing.Size(274, 24);
            this.txtCategoryname.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCategory.Location = new System.Drawing.Point(527, 43);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(88, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.txtCategoryname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(643, 70);
            this.panel1.TabIndex = 3;
            // 
            // gridCategories
            // 
            this.gridCategories.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategories.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridCategories.Location = new System.Drawing.Point(0, 70);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.Size = new System.Drawing.Size(643, 355);
            this.gridCategories.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Acc Name";
            // 
            // txtAccTitle
            // 
            this.txtAccTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAccTitle.Location = new System.Drawing.Point(97, 32);
            this.txtAccTitle.Name = "txtAccTitle";
            this.txtAccTitle.Size = new System.Drawing.Size(131, 24);
            this.txtAccTitle.TabIndex = 1;
            this.txtAccTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drpAccCategory
            // 
            this.drpAccCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.drpAccCategory.FormattingEnabled = true;
            this.drpAccCategory.Location = new System.Drawing.Point(310, 29);
            this.drpAccCategory.Name = "drpAccCategory";
            this.drpAccCategory.Size = new System.Drawing.Size(108, 26);
            this.drpAccCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numQuantity.Location = new System.Drawing.Point(508, 32);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 24);
            this.numQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // btnAddAccessory
            // 
            this.btnAddAccessory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAccessory.Location = new System.Drawing.Point(508, 78);
            this.btnAddAccessory.Name = "btnAddAccessory";
            this.btnAddAccessory.Size = new System.Drawing.Size(120, 31);
            this.btnAddAccessory.TabIndex = 6;
            this.btnAddAccessory.Text = "Add Accessory";
            this.btnAddAccessory.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(665, 493);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UET Procurement Solution";
            this.tabControl1.ResumeLayout(false);
            this.AccessoriesPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.AccAddStockPage.ResumeLayout(false);
            this.AccAddStockPage.PerformLayout();
            this.AccCategoryPage.ResumeLayout(false);
            this.EmployeesPage.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AccessoriesPage;
        private System.Windows.Forms.TabPage EmployeesPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage IssueAccPage;
        private System.Windows.Forms.TabPage AvailableAccPage;
        private System.Windows.Forms.TabPage AccAddStockPage;
        private System.Windows.Forms.TabPage AccCategoryPage;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage NewEmpPage;
        private System.Windows.Forms.TabPage AllEmpPage;
        private System.Windows.Forms.TabPage IssuedAccPage;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpAccCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddAccessory;
    }
}

