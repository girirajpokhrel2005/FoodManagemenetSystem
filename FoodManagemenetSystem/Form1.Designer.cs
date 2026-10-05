namespace FoodManagemenetSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategory = new ComboBox();
            lblTitle = new Label();
            nudPrice = new NumericUpDown();
            txtFoodName = new TextBox();
            lblFoodName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnClear = new Button();
            dgvFoodItems = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            btnSummary = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodItems).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Dairy", "Meat", "Vegetables", "Fruit", "Drinks", "Frozen", "Grocery", "Other" });
            cmbCategory.Location = new Point(112, 103);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AccessibleName = "";
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(341, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "FOOD MANAGEMENT SYSTEM";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(112, 146);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 5;
            nudPrice.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(112, 68);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(150, 27);
            txtFoodName.TabIndex = 6;
            txtFoodName.TextChanged += fisj;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(12, 71);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(94, 20);
            lblFoodName.TabIndex = 7;
            lblFoodName.Text = "Food Name :";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 106);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 146);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(66, 20);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price ($):";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 182);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(113, 182);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 27);
            nudQuantity.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(358, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvFoodItems
            // 
            dgvFoodItems.AllowUserToAddRows = false;
            dgvFoodItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodItems.BackgroundColor = SystemColors.ControlLight;
            dgvFoodItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodItems.Location = new Point(12, 362);
            dgvFoodItems.MultiSelect = false;
            dgvFoodItems.Name = "dgvFoodItems";
            dgvFoodItems.ReadOnly = true;
            dgvFoodItems.RowHeadersWidth = 51;
            dgvFoodItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodItems.Size = new Size(659, 235);
            dgvFoodItems.TabIndex = 19;
            dgvFoodItems.CellClick += dgvFoodItems_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(477, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 233);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 22;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(113, 226);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(269, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(369, 225);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 25;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(477, 225);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(94, 29);
            btnSummary.TabIndex = 26;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 761);
            Controls.Add(btnSummary);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvFoodItems);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblFoodName);
            Controls.Add(txtFoodName);
            Controls.Add(nudPrice);
            Controls.Add(lblTitle);
            Controls.Add(cmbCategory);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Food Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCategory;
        private Label lblTitle;
        private NumericUpDown nudPrice;
        private TextBox txtFoodName;
        private Label lblFoodName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnAdd;
        private Button btnClear;
        private DataGridView dgvFoodItems;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private Button btnSummary;
    }
}
