namespace FoodManagementSystem.Models
{
    public class FoodItem : InventoryItem
    {
        public string Category { get; set; }

        public decimal Price { get; set; }

        public FoodItem(
            int foodID,
            string foodName,
            string category,
            decimal price,
            int quantity)
            : base(foodID, foodName, quantity)
        {
            Category = category;
            Price = price;
        }

        public override string GetStockStatus()
        {
            if (Quantity <= 5)
            {
                return "Low Stock";
            }

            return "In Stock";
        }
    }
}