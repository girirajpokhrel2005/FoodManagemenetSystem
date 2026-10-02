namespace FoodManagementSystem.Models
{
    public class FoodItem
    {
        public int FoodID { get; set; }

        public string FoodName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public FoodItem(
            int foodID,
            string foodName,
            string category,
            decimal price,
            int quantity)
        {
            FoodID = foodID;
            FoodName = foodName;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }
}