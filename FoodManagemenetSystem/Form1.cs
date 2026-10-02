
using FoodManagementSystem.Models;
namespace FoodManagemenetSystem
{
    public partial class Form1 : Form
    {
        private readonly List<FoodItem> foodItems = new List<FoodItem>();
        private int nextFoodId = 1;
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
    }
}
