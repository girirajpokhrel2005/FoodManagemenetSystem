using FoodManagementSystem.Models;

namespace FoodManagemenetSystem
{
    public partial class Form1 : Form
    {
        // Stores all food items while the program is running
        private readonly List<FoodItem> foodItems = new List<FoodItem>();

        // Used to generate a unique ID for each food item
        private int nextFoodId = 1;

        // Stores the item selected from the DataGridView
        private FoodItem? selectedFood = null;

        public Form1()
        {
            InitializeComponent();

            // Connect the buttons to their methods
            // (-= first so nothing runs twice if the Designer already connected them)
            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            dgvFoodItems.CellClick -= dgvFoodItems_CellClick;
            dgvFoodItems.CellClick += dgvFoodItems_CellClick;

            // Clicking a cell should select the whole row,
            // otherwise SelectedRows stays empty and Update/Delete do nothing
            dgvFoodItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodItems.MultiSelect = false;

            // NumericUpDown max is 100 by default, so bigger prices would cause errors
            nudPrice.DecimalPlaces = 2;
            nudPrice.Maximum = 1000000;
            nudQuantity.Maximum = 10000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // =========================
        // TEMPORARY FIX FOR DESIGNER ERRORS
        // These two empty methods stop the CS0103 build errors.
        // You can delete them once you remove the matching lines
        // from Form1.Designer.cs (lines 78 and 86).
        // =========================
        private void numericUpDown1_ValueChanged(object? sender, EventArgs e)
        {

        }

        private void fisj(object? sender, EventArgs e)
        {

        }

        // =========================
        // ADD FOOD
        // =========================
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string foodName = txtFoodName.Text.Trim();

            // Validate food name
            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show(
                    "Please enter a food name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFoodName.Focus();
                return;
            }

            // Validate category
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate price
            if (nudPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than zero.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Create a new FoodItem object
            FoodItem newFood = new FoodItem(
                nextFoodId,
                foodName,
                cmbCategory.Text,
                nudPrice.Value,
                (int)nudQuantity.Value);

            // Add the object to the list
            foodItems.Add(newFood);

            // Prepare ID for next food item
            nextFoodId++;

            // Update table and clear inputs
            RefreshFoodGrid();
            ClearInputs();
        }

        // =========================
        // REFRESH TABLE
        // =========================
        private void RefreshFoodGrid()
        {
            // Remove old binding first
            dgvFoodItems.DataSource = null;

            // Bind the updated list
            dgvFoodItems.DataSource = foodItems;

            // Highlight food items with low stock
            HighlightLowStock();

            // Don't leave a row highlighted after refreshing
            dgvFoodItems.ClearSelection();
        }

        // =========================
        // CLEAR INPUTS
        // =========================
        private void ClearInputs()
        {
            txtFoodName.Clear();
            cmbCategory.SelectedIndex = -1;
            nudPrice.Value = 0;
            nudQuantity.Value = 0;

            txtFoodName.Focus();
        }

        // =========================
        // SELECT FOOD FROM TABLE
        // =========================
        private void dgvFoodItems_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedFood =
                dgvFoodItems.Rows[e.RowIndex].DataBoundItem as FoodItem;

            if (selectedFood == null)
            {
                return;
            }

            // Display selected item's information
            txtFoodName.Text = selectedFood.FoodName;
            cmbCategory.Text = selectedFood.Category;
            nudPrice.Value = selectedFood.Price;
            nudQuantity.Value = selectedFood.Quantity;
        }

        // =========================
        // UPDATE FOOD
        // =========================
        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvFoodItems.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a food item from the table first.",
                    "Update Food",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            FoodItem? foodToUpdate =
                dgvFoodItems.SelectedRows[0].DataBoundItem as FoodItem;

            if (foodToUpdate == null)
            {
                MessageBox.Show(
                    "Unable to read the selected food item.",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Validate food name
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show(
                    "Please enter a food name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFoodName.Focus();
                return;
            }

            // Validate category
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate price
            if (nudPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than zero.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Update selected object
            foodToUpdate.FoodName = txtFoodName.Text.Trim();
            foodToUpdate.Category = cmbCategory.Text;
            foodToUpdate.Price = nudPrice.Value;
            foodToUpdate.Quantity = (int)nudQuantity.Value;

            RefreshFoodGrid();

            MessageBox.Show(
                "Food item updated successfully.",
                "Update Food",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            selectedFood = null;
            ClearInputs();
        }

        // =========================
        // CLEAR BUTTON
        // =========================
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
            selectedFood = null;

            dgvFoodItems.ClearSelection();
        }

        // =========================
        // DELETE FOOD
        // =========================
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvFoodItems.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a food item to delete.",
                    "Delete Food",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            FoodItem? foodToDelete =
                dgvFoodItems.SelectedRows[0].DataBoundItem as FoodItem;

            if (foodToDelete == null)
            {
                MessageBox.Show(
                    "Unable to read the selected food item.",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {foodToDelete.FoodName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foodItems.Remove(foodToDelete);

                RefreshFoodGrid();

                selectedFood = null;
                ClearInputs();

                MessageBox.Show(
                    "Food item deleted successfully.",
                    "Delete Food",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show(
                    "Please enter a food name or category to search.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtSearch.Focus();
                return;
            }

            List<FoodItem> searchResults = foodItems
                .Where(food =>
                    food.FoodName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    food.Category.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvFoodItems.DataSource = null;
            dgvFoodItems.DataSource = searchResults;

            if (searchResults.Count == 0)
            {
                MessageBox.Show(
                    "No matching food items were found.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshFoodGrid();
            txtSearch.Clear();
            dgvFoodItems.ClearSelection();
        }
        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dgvFoodItems.Rows)
            {
                if (row.DataBoundItem is FoodItem food)
                {
                    if (food.Quantity <= 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                    }
                }
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            int totalItems = foodItems.Count;

            int totalQuantity = foodItems.Sum(food => food.Quantity);

            int lowStockItems = foodItems.Count(food => food.Quantity <= 5);

            MessageBox.Show(
                $"Total Food Items: {totalItems}\n" +
                $"Total Stock Quantity: {totalQuantity}\n" +
                $"Low Stock Items: {lowStockItems}",
                "Stock Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}