
using FoodManagementSystem.Models;
namespace FoodManagemenetSystem
{
    public partial class Form1 : Form
    {
        private readonly List<FoodItem> foodItems = new List<FoodItem>();
        private int nextFoodId = 1;
        private FoodItem? selectedFood = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text.Trim();

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

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than zero.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            FoodItem newFood = new FoodItem(
                nextFoodId,
                foodName,
                cmbCategory.Text,
                nudPrice.Value,
                (int)nudQuantity.Value);

            foodItems.Add(newFood);

            nextFoodId++;

            RefreshFoodGrid();
            ClearInputs();

        }
        private void RefreshFoodGrid()
        {
            dgvFoodItems.DataSource = null;
            dgvFoodItems.DataSource = foodItems;
        }

        private void ClearInputs()
        {
            txtFoodName.Clear();
            cmbCategory.SelectedIndex = -1;
            nudPrice.Value = 0;
            nudQuantity.Value = 0;

            txtFoodName.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvFoodItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedFood = dgvFoodItems.Rows[e.RowIndex].DataBoundItem as FoodItem;

            if (selectedFood == null)
                return;

            txtFoodName.Text = selectedFood.FoodName;
            cmbCategory.Text = selectedFood.Category;
            nudPrice.Value = selectedFood.Price;
            nudQuantity.Value = selectedFood.Quantity;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check whether a row is selected
            if (dgvFoodItems.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a food item from the table first.",
                    "Update Food",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Get the selected FoodItem directly from the highlighted row
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

            // Update the selected object
            foodToUpdate.FoodName = txtFoodName.Text.Trim();
            foodToUpdate.Category = cmbCategory.Text;
            foodToUpdate.Price = nudPrice.Value;
            foodToUpdate.Quantity = (int)nudQuantity.Value;

            // Refresh the table
            RefreshFoodGrid();

            MessageBox.Show(
                "Food item updated successfully.",
                "Update Food",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearInputs();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            selectedFood = null;
        }
    }
}




